using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class McostCenter
{
    public string CostCode { get; set; } = null!;

    public string? CostName { get; set; }

    public string? CostStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
