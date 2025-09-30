using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? NextChange { get; set; }

    public string? UserGroup { get; set; }

    public string? Inactive { get; set; }

    public string? ManagerId { get; set; }

    public string? StandBy { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? FullPr { get; set; }

    public string? FullPa { get; set; }

    public string? FullGrn { get; set; }

    public string? FullSes { get; set; }

    public string? Inv { get; set; }

    public string? IsActive { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DeviceID { get; set; }
}
