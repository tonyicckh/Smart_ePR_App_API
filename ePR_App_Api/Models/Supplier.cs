using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Supplier
{
    public int SupCode { get; set; }

    public string? SupName { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Address { get; set; }

    public string? Vattin { get; set; }

    public string? AllowSr { get; set; }
}
