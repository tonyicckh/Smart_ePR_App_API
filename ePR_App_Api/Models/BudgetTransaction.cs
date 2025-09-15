using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class BudgetTransaction
{
    public int DocEntry { get; set; }

    public string? FromDocNum { get; set; }

    public string? ToDocNum { get; set; }

    public string? TranType { get; set; }

    public decimal? TranAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? Reference { get; set; }

    public string? RefStatus { get; set; }

    public string? BlockBg { get; set; }
}
