using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class PostingPeriod1
{
    public int Pyear { get; set; }

    public string Pmonth { get; set; } = null!;

    public string? DocStatus { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual PostingPeriod PyearNavigation { get; set; } = null!;
}
