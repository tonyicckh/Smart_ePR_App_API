using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Ses1
{
    public string Sesnum { get; set; } = null!;

    public int LineNum { get; set; }

    public string? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? BaseType { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? DocCur { get; set; }

    public string? UoM { get; set; }

    public string? DocStatus { get; set; }

    public decimal? Price { get; set; }

    public string? Reference { get; set; }

    public string? LongText { get; set; }

    public decimal? Qty { get; set; }

    public decimal? LineTotal { get; set; }

    public string? DocAction { get; set; }

    public decimal? Term { get; set; }

    public string? Remark { get; set; }

    public decimal? LineAmount { get; set; }

    public int? VisOrder { get; set; }

    public string? FullItemDesc { get; set; }

    public string? Reason { get; set; }

    public string? CancelledBy { get; set; }

    public DateTime? Cancelleddate { get; set; }

    public string? Sapnum { get; set; }

    public string? LastError { get; set; }

    public string? Integration { get; set; }

    public string? IsUpdate { get; set; }

    public string? CancelState { get; set; }

    public virtual Se SesnumNavigation { get; set; } = null!;
}
