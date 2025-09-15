using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class MuoM
{
    public string UoMcode { get; set; } = null!;

    public string? UoMname { get; set; }

    public string? OldUoMcode { get; set; }

    public string? UoMstatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
