using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class PrwaverApproval
{
    public int DocKey { get; set; }

    public string UserId { get; set; } = null!;

    public string? DocStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? VisOrder { get; set; }

    public string? ChangeUser { get; set; }
}
