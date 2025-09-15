using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class PostingPeriod
{
    public int Pyear { get; set; }

    public string? DocStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<PostingPeriod1> PostingPeriod1s { get; set; } = new List<PostingPeriod1>();
}
