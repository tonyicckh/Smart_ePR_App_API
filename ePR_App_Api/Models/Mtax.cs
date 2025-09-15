using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mtax
{
    public string TaxCode { get; set; } = null!;

    public string? TaxName { get; set; }

    public string? TaxStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
