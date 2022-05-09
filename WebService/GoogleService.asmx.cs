using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for GoogleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GoogleService : System.Web.Services.WebService
    {
        private string client_id = "1075264982100-jlub7osrjlrpo16s134lffifcphsso60.apps.googleusercontent.com";
        private string client_secret = "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";
        private string redirection_url = "https://localhost:44349/ShowUser.aspx";
        private string url = "https://accounts.google.com/o/oauth2/token";

        public UserClass GetUserProfile(string access_token)
        {
            string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + access_token;

            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;

            Stream dataStream = request.GetResponse().GetResponseStream();
            string responseFromServer = new StreamReader(dataStream).ReadToEnd();

            return new JavaScriptSerializer().Deserialize<UserClass>(responseFromServer);
        }

        [WebMethod]
        public UserClass GetToken(string code)
        {
            string post = "grant_type=authorization_code&code=" + code + "&client_id=" + client_id + "&client_secret=" + client_secret + "&redirect_uri=" + redirection_url + "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";

            byte[] bytes = new UTF8Encoding().GetBytes(post);

            Stream outputstream = null;
            try
            {
                request.ContentLength = bytes.Length;
                outputstream = request.GetRequestStream();
                outputstream.Write(bytes, 0, bytes.Length);
            }
            catch { }
            var streamReader = new StreamReader(request.GetResponse().GetResponseStream());
            string responseFromServer = streamReader.ReadToEnd();

            TokenClass token = new JavaScriptSerializer().Deserialize<TokenClass>(responseFromServer);
            return GetUserProfile(token.access_token);
        }

        [WebMethod]
        public bool GoogleSignUp(UserClass userinfo)
        {
            string sql = "SELECT * FROM tblUser WHERE Email = '" + userinfo.email + "'";
            if (SQLQuery.ExecuteQuery(sql).Rows.Count == 0)
            {
                sql = "INSERT INTO tblUser VALUES (N'" + userinfo.email + "', '" + userinfo.email + "', '" + userinfo.email + "', N'" + userinfo.name + "', N'" + userinfo.gender + "', '" + userinfo.locale + "', N'" + userinfo.picture + "', 0, 0)";
                return SQLQuery.ExecuteNonQuery(sql) > 0;
            }
            return false;
        }
    }
}
