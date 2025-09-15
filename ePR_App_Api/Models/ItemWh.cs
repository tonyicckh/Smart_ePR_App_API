using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class ItemWh
{
    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? UoM { get; set; }

    public string? MaterialType { get; set; }

    public string? PlantCode { get; set; }

    public string? MaterialGroup { get; set; }

    public decimal? Uprice { get; set; }

    public string? Currency { get; set; }
}
