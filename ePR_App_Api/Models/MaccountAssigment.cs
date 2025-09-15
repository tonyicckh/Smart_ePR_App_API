using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class MaccountAssigment
{
    public string AcctCode { get; set; } = null!;

    public string? AcctName { get; set; }

    public string? AcctStatus { get; set; }

    public DateTime? CreatedDate { get; set; }
}
