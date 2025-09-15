using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mcurrency
{
    public string CurCode { get; set; } = null!;

    public string? CurName { get; set; }

    public string? CurStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
