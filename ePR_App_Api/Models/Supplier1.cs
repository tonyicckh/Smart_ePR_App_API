using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Supplier1
{
    public int SupCode { get; set; }

    public int LineNum { get; set; }

    public string? FrameDescription { get; set; }

    public string? FrameNo { get; set; }

    public string? DocStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
