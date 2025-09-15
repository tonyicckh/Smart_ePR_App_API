using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VDocumentApproval
{
    public int DocEntry { get; set; }

    public string? BaseDocNum { get; set; }

    public string? BaseType { get; set; }

    public string? UserCode { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserName { get; set; }
}
