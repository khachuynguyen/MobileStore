using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace MobileShop
{
    public class SQL
    {
        SqlConnection conn;
        public SQL()
        {
            conn = new SqlConnection("Data Source=LAPTOP-5EUQFSD7\\KHACHUY;Initial Catalog=MobileShop;Integrated Security=True");
        }
        public SqlConnection Conn 
            { get { return conn; } }
        public DataTable getData(SqlCommand cmd)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool exInsert(SqlCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }
        public int executeNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                int kq = sqlCommand.ExecuteNonQuery();
                conn.Close();
                return kq;
            }
            catch
            {
                conn.Close() ;
                return 0;
            }
        }
        public DataTable getDataTable(String sql) {
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,conn);   
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        public object executeScalar(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                object tmp = sqlCommand.ExecuteScalar();
                conn.Close();
                return tmp;
            }
            catch
            {
                return null;
            }
        }
    }
}