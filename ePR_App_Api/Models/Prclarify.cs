using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Prclarify
{
    public int DocEntry { get; set; }

    public int DocKey { get; set; }

    public string? UserId { get; set; }

    public string? Email { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? MailStatus { get; set; }

    public DateTime? MailDate { get; set; }

    public string? MailBody { get; set; }

    public string? Comments { get; set; }

}
