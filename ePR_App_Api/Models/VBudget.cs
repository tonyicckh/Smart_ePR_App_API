using System;
using System.Collections.Generic;

namespace ePR_App_Api.Models;

public partial class VBudget
{
    public int DocNum { get; set; }

    public string? Dscription { get; set; }

    public string? BudgetType { get; set; }

    public DateOnly? ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }

    public decimal? InitAmount { get; set; }

    public decimal? AdditionalAmount { get; set; }

    public decimal? ApplyAmount { get; set; }

    public decimal? TransferAmount { get; set; }

    public decimal? Balance { get; set; }

    public string? DocStatus { get; set; }

    public string? Project { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Division { get; set; }

    public string? Dep { get; set; }

    public string? DocNo { get; set; }
}
