using System.Data;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable GetUser(string username)
        {
            string sql = "SELECT * FROM tblUser WHERE Username = N'" + username + "'";
            DataTable dt = SQLQuery.ExecuteQuery(sql);
            dt.TableName = "tblUser";
            return dt;
        }

        [WebMethod]
        public bool Login(string username, string password)
        {
            string sql = "SELECT * FROM tblUser WHERE Username = N'" + username + "' AND Password = '" + password + "'";
            return SQLQuery.ExecuteQuery(sql).Rows.Count > 0;
        }

        [WebMethod]
        public bool IsFirstLogin(string username)
        {
            string sql = "SELECT * FROM tblUser WHERE Username = N'" + username + "' AND Status = 0";
            return SQLQuery.ExecuteQuery(sql).Rows.Count > 0;
        }

        [WebMethod]
        public bool ChangePassword(string username, string password)
        {
            string sql = "UPDATE tblUser SET Password = '" + password + "', Status = 1 WHERE Username = N'" + username + "'";
            return SQLQuery.ExecuteQuery(sql).Rows.Count > 0;
        }
    }
}
