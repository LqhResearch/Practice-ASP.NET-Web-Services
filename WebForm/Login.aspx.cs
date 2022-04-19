using System;

namespace WebForm
{
    public partial class Login : System.Web.UI.Page
    {
        Service.ServiceSoapClient wcf = new Service.ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(wcf.Login(txtUsername.Text, txtPassword.Text))
            {
                Session["admin_login"] = true;
                Response.Redirect("/Default.aspx");
            }
        }
    }
}