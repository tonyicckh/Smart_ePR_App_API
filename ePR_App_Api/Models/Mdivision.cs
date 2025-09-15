using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mdivision
{
    public string DivCode { get; set; } = null!;

    public string? DivName { get; set; }

    public string? DivStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
