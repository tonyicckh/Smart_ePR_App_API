using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Se
{
    public string Sesnum { get; set; } = null!;

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

    public string? CancelState { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? RecurringPeriod { get; set; }

    public int? Onday { get; set; }

    public string? Reason { get; set; }

    public virtual ICollection<Ses1> Ses1s { get; set; } = new List<Ses1>();
}
