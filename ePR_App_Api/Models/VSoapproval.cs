using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VSoapproval
{
    public string DocNum { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? DocStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? VisOrder { get; set; }

    public string? ChangeUser { get; set; }

    public string? MailStatus { get; set; }

    public DateTime? MailDate { get; set; }

    public string? MailBody { get; set; }

    public DateTime ApprovedDate { get; set; }

    public string? Name { get; set; }

    public string? DocStatusApp { get; set; }
}
