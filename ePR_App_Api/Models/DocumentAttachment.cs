using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class DocumentAttachment
{
    public int DocEntry { get; set; }

    public string? BaseDocNum { get; set; }

    public string? BaseType { get; set; }

    public string? FullFileName { get; set; }

    public string? FileLoc { get; set; }

    public string? UserCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? DocStatus { get; set; }
}
