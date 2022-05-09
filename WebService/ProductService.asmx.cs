using System.Data;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable GetProduct()
        {
            string sql = "SELECT * FROM tblProduct";
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblProduct";
            return dt;
        }

        [WebMethod]
        public DataTable GetProductbyId(string productId)
        {
            string sql = "SELECT * FROM tblProduct WHERE ProductID = " + productId;
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblProduct";
            return dt;
        }

        [WebMethod]
        public bool AddProduct(string name, int price, string thumnail)
        {
            string sql = "INSERT INTO tblProduct (ProductName, Price, Thumbnail) VALUES (N'" + name + "', " + price + ", N'" + thumnail + "')";
            return SQLQuery.ExecuteNonQuery(sql) > 0;
        }

        [WebMethod]
        public bool RatingProduct(string username, int productID, int star)
        {
            string sql = "INSERT INTO tblRating VALUES (" + productID + ", N'" + username + "', " + star + ")";
            return SQLQuery.ExecuteNonQuery(sql) > 0;
        }
    }
}
