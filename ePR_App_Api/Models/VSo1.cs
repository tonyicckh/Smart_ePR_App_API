using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VSo1
{
    public string DocNum { get; set; } = null!;

    public int LineNum { get; set; }

    public string? SiteCode { get; set; }

    public string? SiteName { get; set; }

    public string? UoM { get; set; }

    public decimal? Qty { get; set; }

    public decimal? LineTotal { get; set; }

    public string? LineStatus { get; set; }

    public string? BaseDocNum { get; set; }

    public int? BaseLine { get; set; }
}
