using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Prhrt
{
    public int DocKey { get; set; }

    public string? VendorName { get; set; }

    public string? Title { get; set; }

    public string? Evalue { get; set; }

    public string? Period { get; set; }

    public string? Scope { get; set; }

    public string? Nature { get; set; }

    public string? Description { get; set; }

    public string? Assessment { get; set; }

    public string? Impact { get; set; }

    public string? Mitigation { get; set; }

    public string? NextApprover { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CreatedBy { get; set; }

    public string? DocStatus { get; set; }

    public virtual Pr DocKeyNavigation { get; set; } = null!;
}
