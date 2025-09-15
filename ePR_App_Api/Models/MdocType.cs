using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class MdocType
{
    public string DocCode { get; set; } = null!;

    public string? DocName { get; set; }

    public string? DocStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? VisOrder { get; set; }
}
