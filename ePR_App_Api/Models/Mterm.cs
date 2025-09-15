using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mterm
{
    public string TermCode { get; set; } = null!;

    public string? TermName { get; set; }

    public string? TermStatus { get; set; }

    public int? NoofDay { get; set; }

    public DateTime? CreatedDate { get; set; }
}
