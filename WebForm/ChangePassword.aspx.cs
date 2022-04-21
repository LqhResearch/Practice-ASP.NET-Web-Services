using System;

namespace WebForm
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        Service.ServiceSoapClient service = new Service.ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            if(txtPassword1.Text == txtPassword2.Text && txtPassword1.Text != "")
            {
                service.ChangePassword(username, txtPassword1.Text);
                Response.Redirect("/ShowUser.aspx?username=" + username);
            }
        }
    }
}