using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class EmailTemplate
{
    public string TempType { get; set; } = null!;

    public string? Htmltemplate { get; set; }

    public int? CountNum { get; set; }

    public string? Subject { get; set; }

    public string? MailStatus { get; set; }

    public string? DocType { get; set; }
}
