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
        public bool AddComment(string productID, string username, string content, string star = "-1")
        {
            string sql = "INSERT INTO tblComment (ProductID, Username, StarNumber, Content) VALUES (" + productID + ", N'" + username + "', " + star + ", N'" + content + "')";
            return SQLQuery.ExecuteNonQuery(sql) > 0;
        }

        [WebMethod]
        public DataTable ShowCommentByProductId(string productID)
        {
            string sql = "SELECT * FROM tblComment, tblProduct, tblUser WHERE tblComment.Username = tblUser.Username AND tblComment.ProductID = tblProduct.ProductID AND tblProduct.ProductID = " + productID;
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblComment";
            return dt;
        }
    }
}
