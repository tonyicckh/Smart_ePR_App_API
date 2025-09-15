using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Pah
{
    public string Panum { get; set; } = null!;

    public int LineNum { get; set; }

    public string? ItemName { get; set; }

    public decimal? Qty { get; set; }

    public string? UoM { get; set; }

    public decimal? Uprice { get; set; }

    public decimal? NetValue { get; set; }

    public decimal? Discount { get; set; }

    public string? Prnum { get; set; }

    public string? DocCur { get; set; }

    public decimal? LineTotal { get; set; }

    public int? VisOrder { get; set; }

    public virtual Pa PanumNavigation { get; set; } = null!;
}
