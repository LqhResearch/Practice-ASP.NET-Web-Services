using System;

namespace WebForm
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        UserService.UserServiceSoapClient user = new UserService.UserServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            if (txtPassword1.Text == txtPassword2.Text && txtPassword1.Text != "")
            {
                user.ChangePassword(username, txtPassword1.Text);
                Response.Redirect("/ShowUser.aspx?username=" + username);
            }
        }
    }
}