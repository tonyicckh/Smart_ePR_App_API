using ePR_App_Api.Models;

namespace ePR_App_Api.Data
{
    public class ReplyCommentRequest
    {
        public ReplyCommentRequest() { }
        public DocumentComment Comment { get; set; }
        //public Prclarify Clarify { get; set; }
    }
}
