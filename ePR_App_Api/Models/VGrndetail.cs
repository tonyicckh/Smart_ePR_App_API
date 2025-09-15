using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VGrndetail
{
    public string Grnnum { get; set; } = null!;

    public string? Panum { get; set; }

    public string? Ponum { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? PostDate { get; set; }

    public string? DeliverRef { get; set; }

    public string? Bill { get; set; }

    public string? Remark { get; set; }

    public string? Sapnum { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelBy { get; set; }

    public string? NextApprover { get; set; }

    public string? LastApprover { get; set; }

    public string? DocStatus { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? CardAddress { get; set; }

    public string? ApprovalUpdated { get; set; }

    public int LineNum { get; set; }

    public string? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Qty { get; set; }

    public string? DocCur { get; set; }

    public string? DocAction { get; set; }

    public decimal? Uprice { get; set; }

    public string? UoM { get; set; }

    public string? LineStatus { get; set; }

    public string? ItemName { get; set; }

    public string? PlantCode { get; set; }

    public string? Sloc { get; set; }

    public decimal? LineTotal { get; set; }

    public string? CancelReason { get; set; }

    public int? VisOrder { get; set; }

    public string? FullItemDesc { get; set; }

    public string? HighRiskDes { get; set; }
}
