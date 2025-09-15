namespace ePR_App_Api.Data
{
    public class FilterModel
    {
        public FilterModel() { }
        public string? DocType { set; get; }
        public string? UserCode { set; get; }
        public string? Type { set; get; }
        public string? Search { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
        public string? Department { set; get; }
        public string? Status { set; get; }
        public int? Start { set; get; }
        public int? Limit { set; get; }
        public string? Load { set; get; }
        public string? RedCheck  { set; get; }
        public string? YellowCheck { set; get; }
        public string? GrennCheck { set; get; }
        public string? NACheck { set; get; }
    }
}
