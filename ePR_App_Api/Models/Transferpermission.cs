using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Transferpermission
{
    public int Code { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Fromuser { get; set; }

    public string? Touser { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? FromStatus { get; set; }

    public string? ToStatus { get; set; }
}
