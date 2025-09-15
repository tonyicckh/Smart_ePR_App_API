using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VSesDetail
{
    public string Sesnum { get; set; } = null!;

    public string? SesnumLineNo { get; set; }

    public string? Ponum { get; set; }

    public string? Panum { get; set; }

    public DateOnly? PostDate { get; set; }

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

    public string? CardCode { get; set; }

    public string? CardNam { get; set; }

    public string? CardAddress { get; set; }

    public string? ExternalNum { get; set; }

    public string? ServiceLocation { get; set; }

    public DateOnly? ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }

    public string? Ref { get; set; }

    public string? DocStatus { get; set; }

    public string? ApprovalUpdated { get; set; }

    public string? CancelReason { get; set; }

    public string? LastError { get; set; }

    public string? IntStatus { get; set; }

    public int? LineNum { get; set; }

    public string? BaseEntry { get; set; }

    public int? BaseLine { get; set; }

    public string? BaseType { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? DocCur { get; set; }

    public string? UoM { get; set; }

    public string? LineStatus { get; set; }

    public decimal? Price { get; set; }

    public string? Reference { get; set; }

    public string? LongText { get; set; }

    public decimal? Qty { get; set; }

    public decimal? LineTotal { get; set; }

    public string? DocAction { get; set; }

    public decimal? Term { get; set; }

    public string? LineRemark { get; set; }

    public decimal? LineAmount { get; set; }

    public string? FullItemDesc { get; set; }

    public int? RecurringPeriod { get; set; }

    public int? Onday { get; set; }

    public DateOnly StartDate { get; set; }

    public string? Reason { get; set; }

    public string? CancelledBy { get; set; }

    public DateTime? Cancelleddate { get; set; }

    public string? LineSapnum { get; set; }

    public string? LineLastError { get; set; }

    public string? LineIntegration { get; set; }

    public string? HighRiskDes { get; set; }
}
