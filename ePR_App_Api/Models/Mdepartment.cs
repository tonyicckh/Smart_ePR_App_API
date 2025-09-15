using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mdepartment
{
    public string DepCode { get; set; } = null!;

    public string? DepName { get; set; }

    public string? OldDepCode { get; set; }

    public string? DepStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
