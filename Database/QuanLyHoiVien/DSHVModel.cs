using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_management_appication.Class;

namespace Gym_management_appication.Database.QuanLyHoiVien
{
    class DSHVModel
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable GetData(string str)
        {
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(str, con))
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
        public void Insert(Class.hoiVien hoiVien)
        {
            sqlQuery = "insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia) values ('"+hoiVien.ma + "',N'" +
                hoiVien.ten+"','" + hoiVien.tuoi.ToString() + "',N'" + hoiVien.gioiTinh+ "','" + hoiVien.sdt  + "','" + hoiVien.ngayThamGia.ToString("MM/dd/yyyy") + "')";
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
        public void FullInsert(Class.hoiVien hoiVien)
        {
            sqlQuery = "insert into Member (ma, ten,tuoi, gioiTinh,soDT, ngayThamGia, ngayKetThuc) values ('" + hoiVien.ma + "',N'" +
                hoiVien.ten + "','" + hoiVien.tuoi.ToString() + "',N'" + hoiVien.gioiTinh + "','" + hoiVien.sdt + "','" + hoiVien.ngayThamGia.ToString("MM/dd/yyyy") + "','" + hoiVien.ngayTKetThuc.ToString("MM/dd/yyyy") + "')";
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
        public void Update(Class.hoiVien hoiVien)
        {
            sqlQuery = "update Member set ma = N'" + hoiVien.ma.Trim() + "', ten = N'" + hoiVien.ten + "', tuoi = '" +
                hoiVien.tuoi + "', gioiTinh= N'" + hoiVien.gioiTinh + "', soDT =" + hoiVien.sdt + ", ngayThamGia = '" + hoiVien.ngayThamGia.ToString("MM/dd/yyyy") + "' where ma=N'"+hoiVien.ma.Trim()+"'";
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
        public void FullUpdate(Class.hoiVien hoiVien)
        {
            sqlQuery = "update Member set ma = N'" + hoiVien.ma.Trim() + "', ten = N'" + hoiVien.ten + "', tuoi = '" +
                hoiVien.tuoi + "', gioiTinh= N'" + hoiVien.gioiTinh + "', soDT =" + hoiVien.sdt + ", ngayThamGia = '" + hoiVien.ngayThamGia.ToString("MM/dd/yyyy") + "', ngayKetThuc= '" + hoiVien.ngayTKetThuc.ToString("MM/dd/yyyy") + "' where ma=N'" + hoiVien.ma.Trim() + "'";
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
        public void Delete(string ID)
        {
            sqlQuery = "delete from Member where ma ='" + ID + "'";
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
    }
}
