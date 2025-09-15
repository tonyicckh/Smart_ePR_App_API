using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class MpurchaseGroup
{
    public int PurGroupCode { get; set; }

    public string? PurGroupName { get; set; }

    public string? PurGroupStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
