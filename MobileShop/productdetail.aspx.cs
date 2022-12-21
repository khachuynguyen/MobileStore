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
    public partial class productdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            SqlConnection con = new SQL().Conn ;
            SqlCommand cmd = new SqlCommand("Select * from tblProducts where ProductID=@id", con);
            cmd.Parameters.Add("id", id);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            String name = dt.Rows[0]["Name"].ToString();
            
            Product.DataSource = dt;
            Product.DataBind();
        }
    }
}