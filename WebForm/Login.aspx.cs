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
            if (service.Login(txtUserName_SignIn.Text, txtPassword_SignIn.Text))
            {
                Session["admin_login"] = true;
                Response.Redirect("/Default.aspx");
            }
        }
    }
}