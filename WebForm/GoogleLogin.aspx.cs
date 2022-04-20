using System;

namespace WebForm
{
    public partial class GoogleLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string client_id = "1075264982100-jlub7osrjlrpo16s134lffifcphsso60.apps.googleusercontent.com";
            string redirection_url = "https://localhost:44349/ShowUser.aspx";
            string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile email&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + client_id;
            Response.Redirect(url);
        }
    }
}