using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VDelegation
{
    public int Code { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Fromuser { get; set; }

    public string? Fromusername { get; set; }

    public string? Touser { get; set; }

    public string? Tousername { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }
}
