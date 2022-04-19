using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        [WebMethod]
        public bool Login(string username, string password)
        {
            string sql = "SELECT * FROM tblUser WHERE Username = N'" + username + "' AND Password = '" + password + "'";
            return SQLQuery.ExecuteQuery(sql).Rows.Count > 0;
        }
    }
}