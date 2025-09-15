using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Pr1
{
    public int DocKey { get; set; }

    public int LineId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? BarCode { get; set; }

    public string? WhsCode { get; set; }

    public decimal? Quantity { get; set; }

    public string? UoM { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? DisPercent { get; set; }

    public decimal? AmountAfDis { get; set; }

    public string? VatCode { get; set; }

    public decimal? LineTotal { get; set; }

    public string? Section { get; set; }

    public string? Location { get; set; }

    public string? Province { get; set; }

    public string? Bomcode { get; set; }

    public string? Project { get; set; }

    public string? PrexpenseType { get; set; }

    public int? VisOrder { get; set; }
}
