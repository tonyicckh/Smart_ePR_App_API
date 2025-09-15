using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Grn1
{
    public string Grnnum { get; set; } = null!;

    public int LineNum { get; set; }

    public string? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Qty { get; set; }

    public string? DocCur { get; set; }

    public string? DocAction { get; set; }

    public decimal? Uprice { get; set; }

    public string? UoM { get; set; }

    public string? DocStatus { get; set; }

    public string? ItemName { get; set; }

    public string? PlantCode { get; set; }

    public string? Sloc { get; set; }

    public decimal? LineTotal { get; set; }

    public int? VisOrder { get; set; }

    public string? FullItemDesc { get; set; }

    public virtual Grn GrnnumNavigation { get; set; } = null!;
}
