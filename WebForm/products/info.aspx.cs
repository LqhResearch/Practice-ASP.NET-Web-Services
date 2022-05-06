using System;
using System.Data;

namespace WebForm.products
{
    public partial class info : System.Web.UI.Page
    {
        ProductService.ProductServiceSoapClient product = new ProductService.ProductServiceSoapClient();
        CommentService.CommentServiceSoapClient comment = new CommentService.CommentServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productId = Request.QueryString["product-id"];
                DataRow row = product.GetProductbyId(productId).Rows[0];

                img.ImageUrl = row["Thumbnail"].ToString();
                txtName.Text = row["ProductName"].ToString();
                txtPrice.Text = row["Price"].ToString();

                rptCommentList.DataSource = comment.ShowCommentByProductId(productId);
                rptCommentList.DataBind();
            }
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            comment.AddComment(Request.QueryString["product-id"], Session["Username"].ToString(), txtComment.Text, "-1");
        }
    }
}