using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mplant
{
    public string PlantCode { get; set; } = null!;

    public string? PlantName { get; set; }

    public string? PlantStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
