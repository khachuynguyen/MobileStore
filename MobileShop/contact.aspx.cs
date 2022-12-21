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
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Email"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        

        protected void btnSend1_Click(object sender, EventArgs e)
        {
            String name = txtName.Value;
            String email = txtEmail.Value;
            String phone = txtPhone.Value;
            String mess = txtMess.Value;
            SqlConnection con = new SQL().Conn;
            SqlCommand cmd = new SqlCommand("INSERT INTO tblContact(Name,Email,Phone,Message) VALUES(@name,@email,@phone,@mess)", con);
            con.Open();
            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("phone", phone);
            cmd.Parameters.Add("mess", mess);
            cmd.CommandType = CommandType.Text;
            if (valid())
            {
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Gửi thành công')</script>");
                reset();
                }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            }
            else
            {
                Response.Write("<script>alert('Kiểm tra lại thông tin')</script>");
            }
            
        }
        public bool valid()
        {
            String name = txtName.Value;
            String email = txtEmail.Value;
            String phone = txtPhone.Value;
            String mess = txtMess.Value;
            if (name == "" || email == "" || phone == "" || mess == "")
                return false;
            else
                return true;
        }
        public void reset()
        {
            txtName.Value = "";
            txtEmail.Value = "";
            txtPhone.Value = "";
            txtMess.Value = "";
        }
    }
}