using System;

namespace WebForm
{
    public partial class Login : System.Web.UI.Page
    {
        Service.ServiceSoapClient service = new Service.ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName_SignIn.Text;
            if (service.Login(username, txtPassword_SignIn.Text))
            {
                Session["admin_login"] = true;
                if (service.IsFirstLogin(username))
                    Response.Redirect("/ChangePassword.aspx?username=" + username);
                Response.Redirect("/ShowUser.aspx?username=" + username);
            }
        }
    }
}