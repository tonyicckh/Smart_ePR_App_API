using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VPr1
{
    public int DocKey { get; set; }

    public string? DocNum { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public DateTime DocDate { get; set; }

    public DateTime? RequireDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? ApprvedUser { get; set; }

    public DateTime? ApprvedDate { get; set; }

    public string? ApprvedUser2 { get; set; }

    public DateTime? ApprvedDate2 { get; set; }

    public string? RejectUser { get; set; }

    public DateTime? RejectDate { get; set; }

    public string? CancelUser { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? Status { get; set; }

    public int? Sapnum { get; set; }

    public string? UDocType { get; set; }

    public string? USupplier1 { get; set; }

    public string? USupplier2 { get; set; }

    public string? USupplier3 { get; set; }

    public string? USupplier4 { get; set; }

    public string? USupplier5 { get; set; }

    public string? URemarks { get; set; }

    public string? UPurProcedure { get; set; }

    public string? UIntegraCode { get; set; }

    public string? UApproBudget { get; set; }

    public string? UDivision { get; set; }

    public string? UDepartment { get; set; }

    public string? UPurType { get; set; }

    public string? UNameofSupp { get; set; }

    public string? UFrmCtctRef { get; set; }

    public string? UPhone { get; set; }

    public decimal? DocTotal { get; set; }

    public string? RejectReason { get; set; }

    public string? Project { get; set; }

    public string? AtchDoc { get; set; }

    public string? Nextapprover { get; set; }

    public string? Clarifyuser { get; set; }

    public string? Direct { get; set; }

    public DateTime? PrintDate { get; set; }

    public int? NewDocEntry { get; set; }

    public string? Cancelreason { get; set; }

    public string? Pastatus { get; set; }

    public string? CreatorName { get; set; }

    public string? ApproverName { get; set; }

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

    public string? Expr2 { get; set; }

    public string? PrexpenseType { get; set; }
}
