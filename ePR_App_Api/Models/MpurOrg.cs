using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class MpurOrg
{
    public string PurOrgCode { get; set; } = null!;

    public string? PurOrgName { get; set; }

    public string? PurStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
