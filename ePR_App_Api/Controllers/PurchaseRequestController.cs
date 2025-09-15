using System.Data;
using ePR_App_Api.Data;
using ePR_App_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ePR_App_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [JwtAuthorize]
    public class PurchaseRequestController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private AppCoreContext app;
        private AppDbContext dbContext;
        public PurchaseRequestController(AppDbContext context, TokenService tokenService, AppCoreContext _app)
        {
            dbContext = context;
            _tokenService = tokenService;
            app = _app;
        }

        [HttpGet("GetPRList")]
        public async Task<IActionResult> GetPRList(string userCode,DateTime? fromDate,DateTime? toDate,string? search,string? searchType,string? division,string? status,string? isRed,string? isYellow,string? isGreen,string? isNA,int start,int limit)
        {
            try
            {
                string fromdate = fromDate?.ToString("yyyy-MM-dd") ?? "1999-01-01";
                string todate = toDate?.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd");

                string sql = $@"
                EXEC App_Api_Get_PR_List 
                    @usercode='{userCode}', 
                    @search='{search}', 
                    @searctype='{searchType}', 
                    @fromdate='{fromdate}', 
                    @todate='{todate}', 
                    @division='{division}', 
                    @status='{status}', 
                    @isRed='{isRed}', 
                    @isYellow='{isYellow}', 
                    @isGreen='{isGreen}', 
                    @isNA='{isNA}', 
                    @start='{start}', 
                    @limit='{limit}'";
                var prlist = await dbContext.App_Api_Get_PR_List.FromSqlRaw(sql).ToListAsync();

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



        [HttpPost("PRDocumentAction")]
        public async Task<IActionResult> PRDocumentAction(List<DocumentAction>? actions)
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
                        if (x.DocType == "PR")
                        {
                            try
                            {
                                var pr = await dbContext.Prs.Where(a => a.DocKey == x.DocKey).FirstOrDefaultAsync();
                                if (pr != null)
                                {
                                    if (x.DocStatus == "Cancelled")
                                    {
                                        pr.CancelUser = x.CreatedBy;
                                        pr.CancelDate = DateTime.Now;
                                        pr.Status = "C";
                                        pr.Prcolor = 2;
                                        total_cancelled++;
                                    }
                                    else if (x.DocStatus == "Approved")
                                    {
                                        pr.ApprvedUser = x.CreatedBy;
                                        pr.ApprvedDate = DateTime.Now;
                                        total_approved++;
                                    }
                                    else if (x.DocStatus == "Rejected")
                                    {
                                        pr.RejectUser = x.CreatedBy;
                                        pr.RejectDate = DateTime.Now;
                                        pr.Status = "R";
                                        pr.Prcolor = 2;
                                        pr.RejectReason = x.Reason;
                                        total_rejected++;
                                    }
                                    pr.MailAction = "Y";
                                    pr.DocAction = "Y";
                                    pr.UpdatedDate = DateTime.Now;
                                    pr.UpdatedUser = x.CreatedBy;
                                    await dbContext.SaveChangesAsync();
                                    await dbContext.Database.ExecuteSqlRawAsync("exec ICC_Set_Next_PR_Approver '" + x.DocKey + "','" + x.CreatedBy + "','" + x.DocStatus.Substring(0, 3) + "'");
                                    total_success++;

                                    DocumentChangeLog change = new DocumentChangeLog();
                                    change.BaseDocNum = x.DocNum;
                                    change.CreatedDate = DateTime.Now;
                                    change.UserCode = x.CreatedBy;
                                    change.NewVal = x.DocStatus;
                                    change.BaseType = "PR";
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
        
        [HttpGet("GetPRDetail")]
        public async Task<IActionResult> GetPRDetail(int? DocKey)
        {
            try
            {
                if (DocKey == null)
                {
                    return BadRequest("Invalid key");
                }
                var header = await dbContext.VPrs.Where(x => x.DocKey == DocKey).FirstOrDefaultAsync();
                if (header == null)
                {
                    return NotFound("Invalid PR");
                }
                var detail = await dbContext.VPr1s.Where(x => x.DocKey == header.DocKey).ToListAsync();
                var attachment = await dbContext.Attachments.Where(x => x.DocId == header.DocKey.ToString() && x.DocType == "PR").ToListAsync();
                var changelog = await dbContext.VDocumentChangeLogs.Where(x => x.BaseDocNum == header.DocKey.ToString() && x.BaseType == "PR").ToListAsync();
                var comment = await dbContext.VDocumentComments.Where(x => x.BaseDocNum == header.DocKey.ToString() && x.BaseType == "PR").ToListAsync();
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
        [HttpPost("ApprovedHRT")]
        public async Task<IActionResult> ApprovedHRT([FromBody] DocumentAction hrt)
        {
            try
            {
                // Add change log
                var change = new DocumentChangeLog
                {
                    BaseDocNum = hrt.DocKey.ToString(),
                    CreatedDate = DateTime.Now,
                    UserCode = hrt.CreatedBy,
                    NewVal = hrt.DocStatus,
                    BaseType = "PR",
                    FieldName = hrt.DocStatus + " HRT"
                };

                await dbContext.DocumentChangeLogs.AddAsync(change);
                await dbContext.SaveChangesAsync();

                // Execute stored procedure
                await dbContext.Database.ExecuteSqlRawAsync(
                    "EXEC ICC_Set_Next_PRHRT_Approver {0}, '{1}', '{2}'",
                    hrt.DocKey, hrt.CreatedBy, hrt.DocStatus
                );
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
        [HttpPost("ApprovedWaiver")]
        public async Task<IActionResult> ApprovedWaiver([FromBody] DocumentAction document)
        {
            try
            {
                // Update Waiver Approval
                var wave = await dbContext.PrwaverApprovals
                    .FirstOrDefaultAsync(x => x.DocKey == document.DocKey && x.UserId == document.CreatedBy);

                if (wave != null)
                {
                    wave.DocStatus = "Approved";
                    wave.CreatedDate = DateTime.Now;
                    await dbContext.SaveChangesAsync();
                }

                // Process Change Logs
                if (document.ChangeLogs != null)
                {
                    foreach (var x in document.ChangeLogs)
                    {
                        var old = await dbContext.DocumentChangeLogs
                            .Where(a => a.BaseDocNum == document.DocKey.ToString() && a.FieldName == x.FieldName)
                            .OrderByDescending(a => a.CreatedDate)
                            .FirstOrDefaultAsync();

                        if (old == null || old.NewVal != x.NewVal)
                        {
                            var change = new DocumentChangeLog
                            {
                                BaseDocNum = document.DocKey.ToString(),
                                BaseType = "PR",
                                FieldName = x.FieldName,
                                NewVal = x.NewVal,
                                OldVal = old?.NewVal,
                                CreatedDate = DateTime.Now,
                                UserCode = x.UserCode
                            };

                            await dbContext.DocumentChangeLogs.AddAsync(change);
                            await dbContext.SaveChangesAsync();
                        }
                    }
                }

                // Update PR Document Waves
                if (document.PRDocument != null)
                {
                    var pr = await dbContext.Prs.FirstOrDefaultAsync(x => x.DocKey == document.DocKey);
                    if (pr != null)
                    {
                        pr.Wave1 = document.PRDocument.Wave1;
                        pr.Wave2 = document.PRDocument.Wave2;
                        pr.Wave3 = document.PRDocument.Wave3;
                        pr.Wave4 = document.PRDocument.Wave4;
                        pr.Wave5 = document.PRDocument.Wave5;
                        pr.Wave6 = document.PRDocument.Wave6;

                        await dbContext.SaveChangesAsync();
                    }
                }
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
        [HttpPost("ReOpenPR")]
        public async Task<IActionResult> ReOpenPR([FromBody] int DocKey)
        {
            try
            {
                // Execute stored procedure
                dbContext.Database.ExecuteSqlRaw("EXEC ICC_ReOpen_PR @p0", DocKey);
                await dbContext.SaveChangesAsync();
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
                c.BaseType = "PR";
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
                var clarify = request.Clarify;
                var clarify_user = await dbContext.Users.Where(x => x.Email == request.Clarify.Email).FirstOrDefaultAsync();
                var pr=await dbContext.Prs.Where(x=>x.DocKey.ToString()==command.BaseDocNum).FirstOrDefaultAsync();
                if (pr == null)
                {
                    return NotFound("PR Notfound");
                }
                if(pr.CreatedUser==command.UserCode || (pr.Nextapprover==command.UserCode && pr.Status == "F"))
                {
                    if (pr.Nextapprover == command.UserCode)
                    {
                        pr.ToEmail =null;
                        Prclarify pc = new Prclarify();
                        var u = await dbContext.Users.Where(x => x.UserId == command.UserCode).FirstOrDefaultAsync();
                        pc.DocKey = pr.DocKey;
                        pc.UserId = command.UserCode;
                        pc.Email = u.Email;
                        pc.CreatedDate = DateTime.Now;
                        pc.MailStatus = "W";
                        pc.Comments = command.Comment;
                        await dbContext.Prclarifies.AddAsync(pc);
                        await dbContext.SaveChangesAsync();
                    }
                    //Requester clarify to approver
                    pr.Status = "P";
                    pr.Nextapprover = pr.Clarifyuser;
                    var prapp = await dbContext.Prapprovals.Where(a => a.UserId.Equals(pr.Clarifyuser, StringComparison.CurrentCultureIgnoreCase) && a.DocKey == pr.DocKey).FirstOrDefaultAsync();
                    if (prapp != null)
                    {
                        prapp.MailStatus = "W";
                        await dbContext.SaveChangesAsync();
                    }
                    pr.Clarifyuser = pr.CreatedUser;
                }
                else
                {
                    //Approver clarify to requester
                    pr.Status = "F";
                    pr.Clarifyuser = pr.Nextapprover;
                    if (clarify != null)
                    {
                        if (clarify_user.UserId == pr.CreatedUser)
                        {
                            pr.Nextapprover = pr.CreatedUser;
                        }
                        else
                        {
                            pr.Nextapprover = clarify_user.UserId;
                            pr.ToEmail = clarify_user.Email;
                        }
                    }
                    else
                    {
                        pr.Nextapprover = pr.CreatedUser;
                        var prapp = await dbContext.Prapprovals.Where(a => a.UserId.Equals(pr.CreatedUser, StringComparison.CurrentCultureIgnoreCase) && a.DocKey == pr.DocKey).FirstOrDefaultAsync();
                        if (prapp != null)
                        {
                            prapp.MailStatus = "W";
                            await dbContext.SaveChangesAsync();
                        }
                    }
                }
                command.IsClarify = "N";
                command.ToUserCode = pr.Nextapprover;
                command.BaseType = "PR";
                pr.MailAction = "Y";
                await dbContext.SaveChangesAsync();
                if ( clarify!=null &&clarify.Email != null)
                {
                    command.Comment = clarify_user.Name + " _ " + command.Comment;
                }
                await dbContext.DocumentComments.AddRangeAsync(command);
                await dbContext.SaveChangesAsync();

                //change log
                DocumentChangeLog c = new DocumentChangeLog();
                c.BaseDocNum = command.BaseDocNum;
                c.CreatedDate = DateTime.Now;
                c.FieldName = "Reply comment";
                c.NewVal = command.Comment;
                c.UserCode = command.UserCode;
                c.BaseType = "PR";
                c.CreatedDate = DateTime.Now;
                await dbContext.DocumentChangeLogs.AddAsync(c);
                await dbContext.SaveChangesAsync();

                if (clarify != null && clarify.Email != null)
                {
                    Prclarify pc = new Prclarify();
                    pc = clarify;
                    pc.UserId = clarify_user.UserId;
                    pc.CreatedDate = DateTime.Now;
                    pc.MailStatus = "W";
                    await dbContext.Prclarifies.AddAsync(pc);
                    await dbContext.SaveChangesAsync();
                }
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
        [HttpGet("GetPRSummary")]
        public async Task<IActionResult> GetPRSummary(int? dockey)
        {
            try
            {
                if (dockey == null)
                {
                    return BadRequest("Invalid key");
                }
                var pr = await dbContext.VPrs.Where(x => x.DocKey == dockey).FirstOrDefaultAsync();
                if (pr == null)
                {
                    return NotFound("PR Notfound");
                }
                var pr1 =await dbContext.VPr1s.Where(x => x.DocKey == dockey).ToListAsync();
                var comment = await dbContext.DocumentComments.Where(x => x.BaseDocNum == dockey.ToString()).OrderByDescending(x => x.CreatedDate).Take(3).OrderBy(x => x.CreatedDate).ToListAsync();
                var prapproval = await dbContext.VPrapprovals.Where(x => x.Dockey == dockey).OrderBy(x => x.Visorder).ToListAsync();
                var prhrtapproval=await dbContext.VPrhrtapprovals.Where(x=>x.DocKey==dockey).OrderBy(x => x.VisOrder).ToListAsync();
                var prwaver = await dbContext.VPrwaviers.Where(x => x.Dockey == dockey).OrderBy(x => x.Visorder).ToListAsync();
                return Ok(new
                {
                    success = true,
                    message = "Success",
                    data = new
                    {
                        pr,pr1, prhrtapproval, prwaver,comment,prapproval
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
