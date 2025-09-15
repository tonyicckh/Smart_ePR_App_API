using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class EmailSummaryDaily
{
    public int DocEntry { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserCode { get; set; }

    public string? DocTime { get; set; }

    public string? DocType { get; set; }

    public string? DocStatus { get; set; }
}
