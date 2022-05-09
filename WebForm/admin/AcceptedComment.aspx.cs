using System;

namespace WebForm.admin
{
    public partial class AcceptedComment : System.Web.UI.Page
    {
        CommentService.CommentServiceSoapClient comment = new CommentService.CommentServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.QueryString["comment-id"] != null)
                {
                    string commentID = Request.QueryString["comment-id"];
                    comment.AcceptedComment(commentID);
                }

                rptCommentList.DataSource = comment.GetCommentNoAccepted();
                rptCommentList.DataBind();
            }
        }
    }
}