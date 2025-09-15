using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class Evaluation
{
    public int DocKey { get; set; }

    public string? SupplierName { get; set; }

    public string? ProjectName { get; set; }

    public int? Rate1 { get; set; }

    public int? Rate2 { get; set; }

    public int? Rate3 { get; set; }

    public int? Rate4 { get; set; }

    public int? Rate5 { get; set; }

    public int? Rate6 { get; set; }

    public int? Rate7 { get; set; }

    public int? Rate8 { get; set; }

    public int? Rate9 { get; set; }

    public int? Rate10 { get; set; }

    public double? Weightage1 { get; set; }

    public double? Weightage2 { get; set; }

    public double? Weightage3 { get; set; }

    public double? Weightage4 { get; set; }

    public double? Weightage5 { get; set; }

    public double? Weightage6 { get; set; }

    public double? Weightage7 { get; set; }

    public double? Weightage8 { get; set; }

    public double? Weightage9 { get; set; }

    public double? Weightage10 { get; set; }

    public double? LineScore1 { get; set; }

    public double? LineScore2 { get; set; }

    public double? LineScore3 { get; set; }

    public double? LineScore4 { get; set; }

    public double? LineScore5 { get; set; }

    public double? LineScore6 { get; set; }

    public double? LineScore7 { get; set; }

    public double? LineScore8 { get; set; }

    public double? LineScore9 { get; set; }

    public double? LineScore10 { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public string? Remark4 { get; set; }

    public string? Remark5 { get; set; }

    public string? Remark6 { get; set; }

    public string? Remark7 { get; set; }

    public string? Remark8 { get; set; }

    public string? Remark9 { get; set; }

    public string? Remark10 { get; set; }

    public double? TotalWeightage { get; set; }

    public double? TotalScore { get; set; }

    public double? TotalScoreAvgPercentage { get; set; }

    public string? Justification { get; set; }

    public virtual Pr DocKeyNavigation { get; set; } = null!;
}
