using System;

namespace WebForm.products
{
    public partial class list : System.Web.UI.Page
    {
        ProductService.ProductServiceSoapClient product = new ProductService.ProductServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            rptList.DataSource = product.GetProduct();
            rptList.DataBind();
        }
    }
}