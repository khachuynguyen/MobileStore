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
    public partial class brand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (Session["Email"] == null)
            {
                Response.Redirect("~/login.aspx");
            }else

            try
            {
                SqlConnection con = new SQL().Conn;
                SqlCommand cmd = new SqlCommand("Select * from tblProducts",con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dsProduct.DataSource = dt;
                dsProduct.DataBind();
            }catch (Exception ex)
            {

            }
        }
    }
}