using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VPa
{
    public long? Rownum { get; set; }

    public string Panum { get; set; } = null!;

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? DocType { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? TermCode { get; set; }

    public string? DocCur { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? HeaderText { get; set; }

    public string? Prnum { get; set; }

    public string? TermPayment { get; set; }

    public string? TermCondition { get; set; }

    public string? IsContract { get; set; }

    public string? Sup1 { get; set; }

    public string? Sup2 { get; set; }

    public string? Sup3 { get; set; }

    public string? Sup4 { get; set; }

    public string? Sup5 { get; set; }

    public string? SubCom1 { get; set; }

    public string? SubCom2 { get; set; }

    public string? SubCom3 { get; set; }

    public string? SubCom4 { get; set; }

    public string? SubCom5 { get; set; }

    public string? Reason { get; set; }

    public string? PurOrg { get; set; }

    public string? PurGroup { get; set; }

    public string? CompanyCode { get; set; }

    public string? ReleaseStrategy { get; set; }

    public string? ReleaseGroup { get; set; }

    public string? ReleaseIndicator { get; set; }

    public string? Incoterms { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? DocTotal { get; set; }

    public string? IncotermsLocation { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelBy { get; set; }

    public string? NextApprover { get; set; }

    public string? LastApprover { get; set; }

    public string? CardAddress { get; set; }

    public string? CardVatTin { get; set; }

    public string? AccountAssignment { get; set; }

    public string? PrkeyList { get; set; }

    public string? TaxGroup { get; set; }

    public string? Patype { get; set; }

    public string? Ponum { get; set; }

    public string? DocStatus { get; set; }

    public string? DeliveryTime { get; set; }

    public string? TermRemark { get; set; }

    public decimal? AfterDiscount { get; set; }

    public string? SdocStatus { get; set; }

    public string? Padescription { get; set; }

    public string? PadescriptionStatus { get; set; }

    public string? Prdate { get; set; }

    public string? PacreatorName { get; set; }

    public string? Dep { get; set; }

    public string? NextApproverName { get; set; }

    public string? ApproveStatus { get; set; }

    public string CardPhone { get; set; } = null!;

    public string? FullPayment { get; set; }

    public string IntStatus { get; set; } = null!;

    public string? LastError { get; set; }

    public string? MailAction { get; set; }

    public string? CreatorClarify { get; set; }

    public int? CurrentApp { get; set; }

    public string? IsChange { get; set; }

    public string? CancelName { get; set; }

    public string? CancelReason { get; set; }

    public DateTime? IntDate { get; set; }

    public string? Div { get; set; }

    public DateTime? AppDate { get; set; }

    public string? IsLegal { get; set; }

    public int HighRisk { get; set; }

    public string? HighRiskDes { get; set; }

    public decimal CostAvoidance { get; set; }

    public decimal CostReduction { get; set; }

    public string? Remark { get; set; }

    public string? CmtClarify { get; set; }
}
