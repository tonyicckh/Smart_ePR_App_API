using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Pa1
{
    public string Panum { get; set; } = null!;

    public int LineNum { get; set; }

    public string? AcctAssignment { get; set; }

    public string? ItemCategory { get; set; }

    public string? ItemCode { get; set; }

    public string? MaterialGroup { get; set; }

    public string? ItemName { get; set; }

    public decimal? Mqty { get; set; }

    public string? MuoM { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public decimal? NetPrice { get; set; }

    public string? DocCur { get; set; }

    public decimal? Uprice { get; set; }

    public string? TaxCode { get; set; }

    public string? PlantCode { get; set; }

    public string? SlocCode { get; set; }

    public decimal? MgrossPrice { get; set; }

    public string? MaterialPotext { get; set; }

    public string? ItemText { get; set; }

    public string? RecordPotext { get; set; }

    public string? ServiceCode { get; set; }

    public string? ServiceName { get; set; }

    public decimal? Sqty { get; set; }

    public decimal? SgrossPrice { get; set; }

    public string? SuoM { get; set; }

    public string? CostCode { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? ApplyQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public string? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? BaseType { get; set; }

    public string? DocStatus { get; set; }

    public string? HeaderText { get; set; }

    public decimal? ServicePercentage { get; set; }

    public string? FullItemDesc { get; set; }

    public int? VisOrder { get; set; }

    public virtual Pa PanumNavigation { get; set; } = null!;
}
