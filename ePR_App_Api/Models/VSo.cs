using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VSo
{
    public string DocNum { get; set; } = null!;

    public DateOnly? DocDate { get; set; }

    public string? Department { get; set; }

    public string? Division { get; set; }

    public string? SrdocNum { get; set; }

    public DateOnly? SrdocDate { get; set; }

    public string? DocCur { get; set; }

    public string? ObjType { get; set; }

    public int? StypeCode { get; set; }

    public string? AccountAssignment { get; set; }

    public DateOnly? DelDate { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddrss { get; set; }

    public string? VatCode { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AfterDiscount { get; set; }

    public decimal? Vatamount { get; set; }

    public decimal? DocTotal { get; set; }

    public int? ContractPeriod { get; set; }

    public string? TermCondition { get; set; }

    public string? Reason { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? AppBy { get; set; }

    public DateTime? AppDate { get; set; }

    public string? RejBy { get; set; }

    public DateTime? RejDate { get; set; }

    public string? RejReason { get; set; }

    public string? CancelBy { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelReason { get; set; }

    public string? NextApprover { get; set; }

    public int? CurrentApp { get; set; }

    public string? DocStatus { get; set; }

    public string? ClarifyUser { get; set; }

    public string? UpdatedCompleted { get; set; }

    public string? CreatorName { get; set; }

    public string? ApproveStatus { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? Div { get; set; }

    public string NextApproverName { get; set; } = null!;
}
