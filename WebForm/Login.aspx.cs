using System;

namespace WebForm
{
    public partial class Login : System.Web.UI.Page
    {
        UserService.UserServiceSoapClient user = new UserService.UserServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName_SignIn.Text;
            if (user.Login(username, txtPassword_SignIn.Text))
            {
                Session["admin_login"] = true;
                if (user.IsFirstLogin(username))
                    Response.Redirect("/ChangePassword.aspx?username=" + username);
                Response.Redirect("/ShowUser.aspx?username=" + username);
            }
        }
    }
}