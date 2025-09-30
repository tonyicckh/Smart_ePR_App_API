using ePR_App_Api.Data;
using ePR_App_Api.Models;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ePR_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [JwtAuthorize]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private AppCoreContext app;
        private AppDbContext dbContext;
        public PurchaseOrderController(AppDbContext context, TokenService tokenService, AppCoreContext _app)
        {
            dbContext = context;
            _tokenService = tokenService;
            app = _app;
        }
        [HttpGet("GetPAList")]
        public async Task<IActionResult> GetPAList(string userCode, DateTime? fromDate, DateTime? toDate, string? search, string? searchType, string? division,string? department, string? status, int start, int limit)
        {
            try
            {
                string fromdate = fromDate?.ToString("yyyy-MM-dd") ?? "1999-01-01";
                string todate = toDate?.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd");

                string sql = $@"
                EXEC App_Api_Get_PA_List 
                    @usercode='{userCode}', 
                    @search='{search}', 
                    @searctype='{searchType}', 
                    @fromdate='{fromdate}', 
                    @todate='{todate}', 
                    @division='{division}', 
                    @department='{department}', 
                    @status='{status}', 
                    @start='{start}', 
                    @limit='{limit}'";
                var prlist = await dbContext.App_Api_Get_PA_List.FromSqlRaw(sql).ToListAsync();

                int totalrow = 0;
                if (prlist != null && prlist.Count > 0)
                {
                    totalrow = prlist[0].TotalRow;
                }
                return Ok(new
                {
                    success = true,
                    message = "Success",
                    result = prlist,
                    pagination = new
                    {
                        start,
                        limit,
                        total = totalrow
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }

        [HttpGet("GetPAPending")] // keeping GET since you call it at login
        public async Task<IActionResult> GetPAPending(string userCode)
        {
            try
            {
                var paList = await dbContext.VPas
                    .Where(x => x.NextApprover == userCode && (x.DocStatus == "Pending"))
                    .ToListAsync();

                foreach (var x in paList)
                {
                    if (string.IsNullOrWhiteSpace(x.NextApprover)) continue;

                    var topic = $"user_{x.NextApprover}"; // match the topic subscribe to in Flutter

                    var msg = new Message
                    {
                        Topic = topic,

                        // Shows banner in background/terminated
                        Notification = new Notification
                        {
                            //Title = "PA Approval Needed",
                            //Body = $"You have a new PA ({x.Panum}) to approve."
                            Title = x.Not_Title,
                            Body = x.Not_Body
                        },

                        // Always include data for navigation on tap
                        Data = new Dictionary<string, string>
                        {
                            ["type"] = "PA",
                            ["docNum"] = x.Panum?.ToString() ?? "",
                            ["docKey"] = x.Panum?.ToString() ?? "",
                            ["route"] = $"/pa/{x.Panum}"
                        },

                        Android = new AndroidConfig
                        {
                            Priority = Priority.High,
                            //TTL = TimeSpan.FromHours(6),
                            CollapseKey = "pa_pending",
                            Notification = new AndroidNotification
                            {
                                ChannelId = "high_importance",          // must exist in Flutter
                                ClickAction = "FLUTTER_NOTIFICATION_CLICK",
                                Tag = $"pa-{x.Panum}"
                            }
                        },

                        Apns = new ApnsConfig
                        {
                            Headers = new Dictionary<string, string>
                            {
                                ["apns-priority"] = "10"               // deliver immediately
                            },
                            Aps = new Aps
                            {
                                Sound = "default",
                                Badge = 1,
                                ThreadId = "pa_pending"
                            }
                        }
                    };

                    var id = await FirebaseMessaging.DefaultInstance.SendAsync(msg);
                    Console.WriteLine($"FCM sent to {topic}: {id}");
                }

                return Ok(new { success = true, sent = paList.Count });
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        [HttpPost("PADocumentAction")]
        public async Task<IActionResult> PADocumentAction(List<DocumentAction>? actions)
        {
            int total_approved = 0;
            int total_rejected = 0;
            int total_cancelled = 0;
            int total_failed = 0;
            int total_success = 0;
            try
            {
                if (actions != null)
                {
                    foreach (var x in actions)
                    {
                        if (x.DocType == "PA")
                        {
                            try
                            {
                                var pa = await dbContext.Pas.Where(a => a.Panum == x.DocNum).FirstOrDefaultAsync();
                                if (pa != null)
                                {
                                    if (x.DocStatus == "Cancelled")
                                    {
                                        pa.CancelBy = x.CreatedBy;
                                        pa.CancelDate = DateTime.Now;
                                        pa.DocStatus = x.DocStatus;
                                        total_cancelled++;
                                    }
                                    else if (x.DocStatus == "Approved")
                                    {
                                        pa.AppBy = x.CreatedBy;
                                        pa.AppDate = DateTime.Now;
                                        total_approved++;
                                    }
                                    else if (x.DocStatus == "Rejected")
                                    {
                                        pa.RejBy = x.CreatedBy;
                                        pa.RejDate = DateTime.Now;
                                        pa.DocStatus = x.DocStatus;
                                        pa.RejectReason = x.Reason;
                                        total_rejected++;
                                    }
                                    pa.MailAction = "Y";
                                    pa.DocAction = "Y";
                                    pa.UpdatedDate = DateTime.Now;
                                    pa.UpdatedBy = x.CreatedBy;
                                    await dbContext.SaveChangesAsync();
                                    await dbContext.Database.ExecuteSqlRawAsync("exec ICC_Set_Next_PA_Approver '" + x.DocNum + "','" + x.CreatedBy + "','" + x.DocStatus.Substring(0, 3) + "'");
                                    total_success++;

                                    DocumentChangeLog change = new DocumentChangeLog();
                                    change.BaseDocNum = x.DocNum;
                                    change.CreatedDate = DateTime.Now;
                                    change.UserCode = x.CreatedBy;
                                    change.NewVal = x.DocStatus;
                                    change.BaseType = "PA";
                                    change.FieldName = x.DocStatus;
                                    await dbContext.DocumentChangeLogs.AddAsync(change);
                                    await dbContext.SaveChangesAsync();
                                }
                            }
                            catch (Exception ex)
                            {
                                total_failed++;
                            }

                        }
                    }
                }
                return Ok(new
                {
                    success = true,
                    message = "Success",
                    total_approved = total_approved,
                    total_cancelled = total_cancelled,
                    total_rejected = total_rejected,
                    total_success = total_success,
                    total_failed = total_failed
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }

        [HttpGet("GetPADetail")]
        public async Task<IActionResult> GetPRDetail(string? Key)
        {
            try
            {
                if (Key == null)
                {
                    return BadRequest("Invalid key");
                }
                var header = await dbContext.VPas.Where(x => x.Panum == Key).FirstOrDefaultAsync();
                if (header == null)
                {
                    return NotFound("Invalid PA");
                }
                var detail = await dbContext.VPa1s.Where(x => x.Panum == header.Panum).ToListAsync();
                var attachment = await dbContext.Attachments.Where(x => x.DocId == header.Panum.ToString() && x.DocType == "PA").ToListAsync();
                var changelog = await dbContext.VDocumentChangeLogs.Where(x => x.BaseDocNum == header.Panum.ToString() && x.BaseType == "PA").ToListAsync();
                var comment = await dbContext.VDocumentComments.Where(x => x.BaseDocNum == header.Panum.ToString() && x.BaseType == "PA").ToListAsync();
                return Ok(new
                {
                    success = true,
                    message = "Success",
                    data = new
                    {
                        header = header,
                        detail = detail,
                        attachment = attachment,
                        changelog = changelog,
                        comment = comment,
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }

        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment([FromBody] DocumentComment? comment)
        {
            try
            {
                if (comment == null)
                {
                    return BadRequest("Invalid model");
                }
                comment.CreatedDate = DateTime.Now;
                await dbContext.DocumentComments.AddAsync(comment);
                await dbContext.SaveChangesAsync();

                DocumentChangeLog c = new DocumentChangeLog();
                c.BaseDocNum = comment.BaseDocNum;
                c.CreatedDate = DateTime.Now;
                c.FieldName = "New Comment";
                c.NewVal = comment.Comment;
                c.UserCode = comment.UserCode;
                c.BaseType = "PA";
                c.CreatedDate = DateTime.Now;
                await dbContext.DocumentChangeLogs.AddAsync(c);
                await dbContext.SaveChangesAsync();
                await dbContext.Database.ExecuteSqlRawAsync(string.Format("EXEC ICC_Auto_Check_Notification '{0}','{1}','{2}','{3}'", comment.BaseType, comment.BaseDocNum, comment.UserCode, comment.Comment));
                return Ok(new
                {
                    success = true,
                    message = "Success",
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }

        //// GET: PAGetComments
        //[HttpGet("PAGetComments")]
        //public async Task<IActionResult> GetComments(string baseDocNum)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(baseDocNum))
        //        {
        //            return BadRequest("Invalid key");
        //        }
        //        var comment = await dbContext.VDocumentComments.Where(x => x.BaseDocNum == baseDocNum && x.BaseType == "PA").OrderByDescending(x => x.CreatedDate).ToListAsync();
        //        return Ok(new
        //        {
        //            success = true,
        //            message = "Success",
        //            data = comment
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new
        //        {
        //            success = false,
        //            message = "Internal Server Error",
        //            details = ex.Message
        //        });
        //    }
        //}

        [HttpPost("ReplyComment")]
        public async Task<IActionResult> ReplyComment([FromBody] ReplyCommentRequest? request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid model");
                }
                var command = request.Comment;
                var pa = await dbContext.Pas.Where(x => x.Panum.ToString() == command.BaseDocNum).FirstOrDefaultAsync();
                if (pa == null)
                {
                    return NotFound("PR Notfound");
                }
                if (pa.CreatedBy == command.UserCode)
                {
                    //Requester clarify to approver
                    pa.DocStatus = "Pending";
                    pa.NextApprover = pa.HeaderText;

                    var paapp = await dbContext.Paapprovals.Where(a => a.UserId.ToLower() == pa.HeaderText.ToLower() && a.Panum == pa.Panum).FirstOrDefaultAsync();
                    if (paapp != null)
                    {
                        paapp.MailStatus = "Z";
                        await dbContext.SaveChangesAsync();
                    }
                    pa.HeaderText = pa.CreatedBy;
                    await dbContext.SaveChangesAsync();
                }
                else
                {
                    //Approver clarify to requester
                    pa.DocStatus = "Clarify";
                    pa.HeaderText = pa.NextApprover;
                    pa.NextApprover = pa.CreatedBy;
                    var paapp = await dbContext.Paapprovals.Where(a => a.UserId != null && pa.HeaderText != null && a.UserId.ToLower() == pa.HeaderText.ToLower() && a.Panum == pa.Panum).FirstOrDefaultAsync();
                    if (paapp != null)
                    {
                        paapp.MailStatus = "W";
                        await dbContext.SaveChangesAsync();
                    }
                    await dbContext.SaveChangesAsync();
                }
                command.IsClarify = "N";
                command.ToUserCode = pa.NextApprover;
                command.BaseType = "PA";
                await dbContext.DocumentComments.AddAsync(command);
                await dbContext.SaveChangesAsync();
                //change log
                DocumentChangeLog c = new DocumentChangeLog();
                c.BaseDocNum = command.BaseDocNum;
                c.CreatedDate = DateTime.Now;
                c.FieldName = "Reply comment";
                c.NewVal = command.Comment;
                c.UserCode = command.UserCode;
                c.BaseType = "PA";
                c.CreatedDate = DateTime.Now;
                await dbContext.DocumentChangeLogs.AddAsync(c);
                await dbContext.SaveChangesAsync();

                await dbContext.Database.ExecuteSqlRawAsync(string.Format("EXEC ICC_Auto_Check_Notification '{0}','{1}','{2}','{3}'", command.BaseType, command.BaseDocNum, command.UserCode, command.Comment));
                return Ok(new
                {
                    success = true,
                    message = "Success",
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }
        [HttpGet("GetPASummary")]
        public async Task<IActionResult> GetPASummary(string? panum)
        {
            try
            {
                if (panum == null)
                {
                    return BadRequest("Invalid key");
                }
                var pa = await dbContext.VPas.Where(x => x.Panum == panum).FirstOrDefaultAsync();
                if (pa == null)
                {
                    return NotFound("PA Notfound");
                }
                var pa1 = await dbContext.VPa1s.Where(x => x.Panum == panum).ToListAsync();
                var comment = await dbContext.VDocumentComments.Where(x => x.BaseDocNum == panum.ToString()).OrderByDescending(x => x.CreatedDate).Take(3).OrderBy(x => x.CreatedDate).ToListAsync();
                var paapproval = await dbContext.VPaapprovals.Where(x => x.Panum == panum).OrderBy(x => x.VisOrder).ToListAsync();
                return Ok(new
                {
                    success = true,
                    message = "Success",
                    data = new
                    {
                        pa,
                        pa1,
                        comment,
                        paapproval
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = "Internal Server Error",
                    details = ex.Message
                });
            }
        }
    }
}
