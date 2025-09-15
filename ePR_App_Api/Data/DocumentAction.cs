using ePR_App_Api.Models;

namespace ePR_App_Api.Data
{
    public class DocumentAction
    {
        public DocumentAction(){}
        public int DocKey { set; get; }
        public string DocNum { set; get; }
        public string DocType { set; get; }
        public string CreatedBy { set; get; }
        public string DocStatus { set; get; }
        public string Reason { set; get; }
        public Pr? PRDocument { set; get; }
        public Pa? PADocument { set; get; }
        public List<DocumentChangeLog>? ChangeLogs { set; get; }
    }
}
