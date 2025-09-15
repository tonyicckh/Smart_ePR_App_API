using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Mvendor
{
    public string VendorCode { get; set; } = null!;

    public string? VendorName1 { get; set; }

    public string? VendorName2 { get; set; }

    public string? AddressEn { get; set; }

    public string? VendorStatus { get; set; }

    public string? Vattin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Sapjson { get; set; }
}
