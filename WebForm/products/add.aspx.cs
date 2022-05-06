using System;
using System.IO;

namespace WebForm.products
{
    public partial class add : System.Web.UI.Page
    {
        ProductService.ProductServiceSoapClient product = new ProductService.ProductServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }

        private string UploadImage()
        {
            string fileName = "";
            if (Page.IsValid && fThumnail.HasFile && CheckFileType(fThumnail.FileName))
            {
                fileName = "/uploads/" + fThumnail.FileName;
                string filePath = MapPath(fileName);
                fThumnail.SaveAs(filePath);
            }
            return fileName;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string thumnail = UploadImage();
            product.AddProduct(txtName.Text, Convert.ToInt32(txtPrice.Text), thumnail);
        }
    }
}