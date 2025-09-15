using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VSr
{
    public string DocNum { get; set; } = null!;

    public DateOnly? DocDate { get; set; }

    public int? StypeCode { get; set; }

    public string? ObjType { get; set; }

    public string? Department { get; set; }

    public string? Division { get; set; }

    public string? Project { get; set; }

    public string? ReqPurpose { get; set; }

    public decimal? DocTotal { get; set; }

    public string? ProcRoute { get; set; }

    public string? NameOfSupplier { get; set; }

    public string? FrameContract { get; set; }

    public string? PotentialName { get; set; }

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

    public string? VendorCode { get; set; }

    public string? Sostatus { get; set; }

    public string? PrintedName { get; set; }

    public DateTime? PrintedDate { get; set; }

    public string? CreatorName { get; set; }

    public string? ApproveStatus { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? Div { get; set; }

    public string NextApproverName { get; set; } = null!;
}
