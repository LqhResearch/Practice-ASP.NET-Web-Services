using System;
using System.Data;

namespace WebForm
{
    public partial class ShowUser : System.Web.UI.Page
    {
        Service.ServiceSoapClient service = new Service.ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["code"] != null)
                {
                    dynamic userinfo = service.GetToken(Request.QueryString["code"]);

                    imgAvatar.ImageUrl = userinfo.picture;
                    lblID.Text = userinfo.id;
                    lblEmail.Text = userinfo.email;
                    lblGender.Text = userinfo.gender;
                    lblName.Text = userinfo.name;
                    lblLocate.Text = userinfo.locale;

                    service.SignUp(userinfo);
                }
                if(Request.QueryString["username"] != null)
                {
                    string username = Request.QueryString["username"];
                    DataTable dt = service.GetUser(username);
                    if(dt != null)
                    {
                        DataRow row = dt.Rows[0];
                        imgAvatar.ImageUrl = dt.Rows[0]["Avatar"].ToString();
                        lblID.Text = "";
                        lblEmail.Text = dt.Rows[0]["Email"].ToString();
                        lblGender.Text = dt.Rows[0]["Gender"].ToString();
                        lblName.Text = dt.Rows[0]["Fullname"].ToString();
                        lblLocate.Text = dt.Rows[0]["Locale"].ToString();
                    }
                }
            }
        }
    }
}