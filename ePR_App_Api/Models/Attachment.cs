using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Attachment
{
    public int AttchId { get; set; }

    public string? DocType { get; set; }

    public string? DocId { get; set; }

    public string? UserId { get; set; }

    public string? OriFileName { get; set; }

    public string? SaveFileName { get; set; }

    public string? Location { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? DocStatus { get; set; }

    public string? F2 { get; set; }
}
