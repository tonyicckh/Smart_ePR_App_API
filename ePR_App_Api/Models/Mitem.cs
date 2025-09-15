using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mitem
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? DefUoM { get; set; }

    public string? ItemStatus { get; set; }

    public string? ItemType { get; set; }

    public string? PlantCode { get; set; }

    public string? ItemGroup { get; set; }

    public decimal? DefPrice { get; set; }

    public string? ItemCur { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? IsItem { get; set; }

    public string? MaterialType { get; set; }

    public string? PolongText { get; set; }
}
