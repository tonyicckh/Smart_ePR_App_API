using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Grn
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

    public string? CancelReason { get; set; }

    public string? LastError { get; set; }

    public string? IntStatus { get; set; }

    public string? CancelState { get; set; }

    public virtual ICollection<Grn1> Grn1s { get; set; } = new List<Grn1>();
}
