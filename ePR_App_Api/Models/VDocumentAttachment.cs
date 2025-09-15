using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VDocumentAttachment
{
    public int DocEntry { get; set; }

    public string? BaseDocNum { get; set; }

    public string? BaseType { get; set; }

    public string? UserCode { get; set; }

    public string? FullFileName { get; set; }

    public string? FileLoc { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserName { get; set; }
}
