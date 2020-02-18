using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // ASP.NET 網頁載入時執行
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // 按 [新增] 鈕執行
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataSource1.InsertParameters["編號"].DefaultValue =
                    txtId.Text;
                SqlDataSource1.InsertParameters["書名"].DefaultValue =
                    txtName.Text;
                SqlDataSource1.InsertParameters["單價"].DefaultValue =
                    txtPrice.Text;
                SqlDataSource1.InsertParameters["圖示"].DefaultValue =
                    FileUpload1.FileName;
                SqlDataSource1.Insert();
                lblShow.ForeColor = System.Drawing.Color.Blue;
                lblShow.Text = "新增成功";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("images") + "/" +
                  FileUpload1.FileName);
                }
            }
            catch (Exception ex)
            {
                lblShow.ForeColor = System.Drawing.Color.Red;
                lblShow.Text = ex.Message;
            }
        }
    }
}