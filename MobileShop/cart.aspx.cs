using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
                Response.Redirect("~/login.aspx");
            string email = Session["Email"].ToString();
            string getUserNameSql = "select UserName from tblUsers where Email='" + email + "'";
            SQL con = new SQL();
            string userName = (string) con.executeScalar(getUserNameSql);
            String id = Request.QueryString["id"];
            if (id != null)
            {
                //kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
                // nếu có thì tăng số lượng lên 1 đơn vị
                // nếu không thì thêm vào
                object tmp;
                string sqlKtra = "select Quantity from Cart where UserName='"+userName+ "' and ProductID='"+id+"'";
                tmp =  con.executeScalar(sqlKtra);
                string sql = "";
                if (tmp != null)
                {
                    tmp = (int) tmp+1;
                    sql = "update Cart set Quantity = "+tmp+" where UserName='" + userName + "' and ProductID='" + id + "'";
                }else
                    sql = "insert into Cart values('"+userName+"','"+id+"',1)";
                con.executeNonQuery(sql);
            }
            string getCart = "select c.*,p.Price from Cart as c, tblProducts as p where UserName='" + userName + "' and c.ProductID = p.ProductID";
            DataTable dataTable = con.getDataTable(getCart);
            int totalPrice = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                totalPrice += int.Parse(row[2].ToString()) * int.Parse(row[3].ToString());
            }
            string getYourMoney = "select Money from Bank where UserName='" + userName + "'";
            object yourMoney = con.executeScalar(getYourMoney);
            try
            {
                yourMoney = (int) yourMoney;
            }
            catch
            {
                // do some thing
            }
            lblYourMoney.Text = yourMoney.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            repeatCart.DataSource= dataTable;
            repeatCart.DataBind();
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            int totalPrice = int.Parse(lblTotalPrice.Text);
            int wallet = int.Parse(lblYourMoney.Text);
            if(totalPrice == 0)
            {
                Response.Write("<script>alert('Giỏ hàng trống')</script>");
                return;
            }
            if(wallet - totalPrice > 0)
            {
                string email = Session["Email"].ToString();
                string getUserNameSql = "select UserName from tblUsers where Email='" + email + "'";
                SQL con = new SQL();
                string userName = (string)con.executeScalar(getUserNameSql);
                string paymentSql = "delete from Cart where UserName ='"+userName+ "'";
                int kq = con.executeNonQuery(paymentSql);
                if(kq > 0)
                {
                    //trừ tiền
                    string sql = "update Bank set Money=Money -" + totalPrice + " where UserName ='"+userName+"'";
                    int rs = con.executeNonQuery(sql);
                    if(rs > 0)
                    {
                        Response.Redirect("~/cart.aspx");
                    }
                    else
                        Response.Write("<script>alert('Thanh toán không thành công')</script>");
                }
               
            }
            else
                Response.Write("<script>alert('Tiền của bạn không đủ')</script>");
        }
    }
}