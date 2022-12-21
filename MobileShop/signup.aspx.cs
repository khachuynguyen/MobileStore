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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
                Session.Remove("Email");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            String us = txtUsername.Value.ToString();
            String email = txtEmail.Value.ToString();
            String fullName = txtFullname.Value.ToString();
            String pass = txtPass.Value.ToString();
            String retype = txtRetype.Value.ToString();
            if(us == "" || email==""|| fullName =="" || pass =="" || retype == "")
            {
                lblEr.Text = "Kiem tra lai thong tin";
                txtPass.Value = "";
                txtRetype.Value = "";
            }
            else
            {
                if(retype == pass)
                {
                SqlConnection conn = new SQL().Conn;
                SqlCommand cmd = new SqlCommand("insert into tblUsers values('"+us+"','"+pass+"','"+email+"','"+fullName+"')",conn);
                conn.Open();
                /*cmd.Parameters.AddWithValue("@us", us);
                cmd.Parameters.AddWithValue("@pas", pass);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@full", fullName);*/
                cmd.CommandType= CommandType.Text;
                   
                    try
                    {
                    cmd.ExecuteNonQuery();   
                    conn.Close();
                        Session["Email"] = email;
                        SQL sql = new SQL();
                        sql.executeNonQuery("insert into Bank values('" + us + "',2000000)");
                        Response.Redirect("~/index.aspx");
                    }
                

                catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                }
                else
                {
                    lblEr.Text = "Mật khẩu không khớp";
                }
            }
        }
    }
}