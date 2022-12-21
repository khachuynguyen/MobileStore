using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace MobileShop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
                Session.Remove("Email");
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtPass.Value == "" || txtUsername.Value == "")
                lblError.Text = "Kiem tra lai thong tin";
            else
            {
                String us = txtUsername.Value;
                String pas = txtPass.Value;
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from tblUsers where Username=@user and Password=@pass",new SQL().Conn);
                cmd.Parameters.AddWithValue("@user",us);
                cmd.Parameters.AddWithValue("@pass", pas);
                cmd.CommandType = CommandType.Text;

                dt = new SQL().getData(cmd);
                if(dt.Rows.Count > 0)
                {
                    Session["Email"] = dt.Rows[0]["Email"];
                    Response.Redirect("~/index.aspx");
                }
                else
                {
                    lblError.Text = "Kiem tra lai thong tin";
                }
            }
        }
    }
}