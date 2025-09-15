using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VDocumentCommentSrso
{
    public int DocEntry { get; set; }

    public string? BaseDocNum { get; set; }

    public string? BaseType { get; set; }

    public string? UserCode { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? IsClarify { get; set; }

    public string? DocStatus { get; set; }

    public string? ToUserCode { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }
}
