using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VPrwavier
{
    public int Dockey { get; set; }

    public string Userid { get; set; } = null!;

    public string? Docstatus { get; set; }

    public DateTime Createddate { get; set; }

    public int? Visorder { get; set; }

    public string? Changeuser { get; set; }

    public string? UserName { get; set; }
}
