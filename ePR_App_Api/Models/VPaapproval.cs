using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VPaapproval
{
    public string? Panum { get; set; } 

    public string? UserId { get; set; }

    public string? DocStatus { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? VisOrder { get; set; }

    public string? UserName { get; set; }

    public string? Ponum { get; set; }
}
