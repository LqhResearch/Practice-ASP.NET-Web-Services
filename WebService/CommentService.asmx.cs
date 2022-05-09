using System.Data;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for CommentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CommentService : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable GetCommentNoAccepted()
        {
            string sql = "SELECT * FROM tblComment, tblProduct WHERE tblComment.Status = 0 AND tblProduct.ProductID = tblComment.ProductID";
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblComment";
            return dt;
        }

        [WebMethod]
        public bool AddComment(string productID, string username, string content, string role)
        {
            string status = role == "1" ? "1" : "0";
            string sql = "INSERT INTO tblComment (ProductID, Username, Status, Content) VALUES (" + productID + ", N'" + username + "', " + status + ", N'" + content + "')";
            return SQLQuery.ExecuteNonQuery(sql) > 0;
        }

        [WebMethod]
        public DataTable ShowCommentByProductId(string productID)
        {
            string sql = "SELECT * FROM tblComment, tblProduct, tblUser WHERE tblComment.Status = 1 AND tblComment.Username = tblUser.Username AND tblComment.ProductID = tblProduct.ProductID AND tblProduct.ProductID = " + productID;
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblComment";
            return dt;
        }

        [WebMethod]
        public bool AcceptedComment(string commentID)
        {
            string sql = "UPDATE tblComment SET Status = 1 WHERE CommentID = " + commentID;
            return SQLQuery.ExecuteNonQuery(sql) > 0;
        }
    }
}
