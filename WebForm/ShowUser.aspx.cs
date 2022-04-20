﻿using System;

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
                }
            }
        }
    }
}