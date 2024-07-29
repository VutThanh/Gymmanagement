using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication.Database
{
    class trangThietBi
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable getData()
        {
            sqlQuery = "select * from [TrangThietBi]";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        da.Fill(result);
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                
            }
            return result;
        }
        public void insertData(Class.trangThietBi data)
        {
            sqlQuery = "insert into TrangThietBi (ten, ma, tinhTrang, ngayMua, giaThanh, baoHanh, ngayHetHanBaoHanh, hangSanXuat) values (N'" +
                data.ten+"',N'" + data.ma + "',N'"+data.tinhTrang+ "','"+
                data.ngayMua+"',"+ data.giaThanh + ","+ data.baoHanh + ",'"+ data.ngayHetHanBaoHanh + "',N'"+ data.hangSanXuat + "') ";
            conString.ConString constring = new conString.ConString();    
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
        }
        public void updateData(Class.trangThietBi data)
        {
            sqlQuery = "update TrangThietBi set ten = N'" + data.ten+ "', tinhTrang = N'" +
                data.tinhTrang + "', ngayMua= '" + data.ngayMua + "', giaThanh=" + data.giaThanh + ", baoHanh=" + data.baoHanh +
                ", ngayHetHanBaoHanh= '" + data.ngayHetHanBaoHanh + "', hangSanXuat= '" + data.hangSanXuat + "' where ma ='" + data.ma + "'";
            conString.ConString constring = new conString.ConString();                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {

            }           
        }
        public void deleteData(Class.trangThietBi data)
        {
            sqlQuery = "delete from TrangThietBi where ma ='" + data.ma + "'";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of       
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {

            }
        }
        public DataTable searchData(string keyword)
        {
            sqlQuery = " select * from [TrangThietBi]";
            sqlQuery += " WHERE ([ten] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([ma] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([tinhTrang] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([ngayMua] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([giaThanh] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([baoHanh] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([ngayHetHanBaoHanh] LIKE CONCAT('%',@sKeyword,'%'))";
            sqlQuery += " OR ([hangSanXuat] LIKE CONCAT('%',@sKeyword,'%'))";

            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@sKeyword", keyword);
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        // this will query your database and return the result to your datatable
                        da.Fill(result);
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
    }
}
