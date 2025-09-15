using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class BaseUrl
{
    public string Code { get; set; } = null!;

    public string? Urllink { get; set; }
}
