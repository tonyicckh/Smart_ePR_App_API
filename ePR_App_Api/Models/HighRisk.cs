using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class HighRisk
{
    public int Code { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }
}
