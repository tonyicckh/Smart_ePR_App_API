using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mslocation
{
    public string SlocCode { get; set; } = null!;

    public string? PlantCode { get; set; }

    public string? SlocName { get; set; }

    public string? SlocStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
