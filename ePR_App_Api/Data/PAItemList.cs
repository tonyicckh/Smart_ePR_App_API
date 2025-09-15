namespace ePR_App_Api.Data
{
    public class PAItemList
    {
        public PAItemList() { }
        public int TotalRow { get; set; }             // Total rows, nullable if SP might return null
        public string? PANum { get; set; }             // PAN number
        public string? Remark { get; set; }            // Remark, can be null
        public string? Division { get; set; }          // Division
        public string? Department { get; set; }        // Department
        public decimal? DocTotal { get; set; }         // Document total
        public DateTime? CreatedDate { get; set; }     // Created date
        public DateTime? DocDate { get; set; }         // Document date
        public string? NextApprover { get; set; }      // Next approver user code, can be null
        public string? NextApproverName { get; set; }  // Next approver name, can be null
        public int? HighRisk { get; set; }            // High risk flag, can be null
        public string? CreatedBy { get; set; }         // Created by user code
        public string? CreatedUserName { get; set; }   // Created by user name
        public string? DocStatus { get; set; }         // Status: Pending, Approved, etc.
    }

}
