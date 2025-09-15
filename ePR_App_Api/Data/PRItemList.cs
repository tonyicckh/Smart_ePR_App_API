namespace ePR_App_Api.Data
{
    public class PRItemList
    {
        public PRItemList()
        {

        }
        public int DocKey { get; set; }
        public string? DocNum { get; set; } 
        public string? Remarks { get; set; } 
        public string? Division { get; set; } 
        public decimal? DocTotal { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DocDate { get; set; }
        public string? NextApprover { get; set; } 
        public string? NextApproverName { get; set; } 
        public int? HighRisk { get; set; }
        public string? UPurProcedure { get; set; }
        public string? CreatedUser { get; set; }
        public string? CreatedUserName { get; set; }
        public string? Status { get; set; }
        public string? DocStatus { get; set; }
        public int TotalRow { get; set; }  // Total rows ignoring pagination
    }
}
