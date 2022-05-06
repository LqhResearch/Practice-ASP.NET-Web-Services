using System;
using System.Data;

namespace WebForm
{
    public partial class ShowUser : System.Web.UI.Page
    {
        GoogleService.GoogleServiceSoapClient google = new GoogleService.GoogleServiceSoapClient();
        UserService.UserServiceSoapClient user = new UserService.UserServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["code"] != null)
                {
                    dynamic userinfo = google.GetToken(Request.QueryString["code"]);

                    imgAvatar.ImageUrl = userinfo.picture;
                    lblID.Text = userinfo.id;
                    lblEmail.Text = userinfo.email;
                    lblGender.Text = userinfo.gender;
                    lblName.Text = userinfo.name;
                    lblLocate.Text = userinfo.locale;

                    google.GoogleSignUp(userinfo);
                    SetSession(userinfo.email);
                }
                if (Request.QueryString["username"] != null)
                {
                    string username = Request.QueryString["username"];
                    DataTable dt = user.GetUser(username);
                    if (dt != null)
                    {
                        DataRow row = dt.Rows[0];
                        imgAvatar.ImageUrl = row["Avatar"].ToString();
                        lblID.Text = "";
                        lblEmail.Text = row["Email"].ToString();
                        lblGender.Text = row["Gender"].ToString();
                        lblName.Text = row["Fullname"].ToString();
                        lblLocate.Text = row["Locale"].ToString();

                        SetSession(username);
                    }
                }
            }
        }

        private void SetSession(string username)
        {
            DataTable dt = user.GetUser(username);
            if (dt.Rows.Count > 0)
            {
                Session["Login"] = true;
                Session["Username"] = dt.Rows[0]["Username"];
                Session["DisplayName"] = dt.Rows[0]["Fullname"];
                Session["Avatar"] = dt.Rows[0]["Avatar"];
                Session["Role"] = dt.Rows[0]["Role"];
            }
        }
    }
}