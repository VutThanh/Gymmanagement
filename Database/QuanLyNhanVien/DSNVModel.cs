using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gym_management_appication.Database.QuanLyNhanVien
{
    class DSNVModel
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
        public DataTable getStaffDetailInfo(string ma)
        {
            sqlQuery = "select ID,HoTen from NHANVIEN " +
                       " where ID = '" + ma + "' ";
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
        public void Insert(string ID, string Ten, string GioiTinh, string Email, string SDT, string DiaChi, string ChucVu, long Luong)
        {
            sqlQuery = "insert into NHANVIEN (ID,HoTen, GioiTinh, Email, SoDT, DiaChi,ChucVu,Luong) values (N'" + ID + "',N'" +
                Ten + "',N'" + GioiTinh + "',N'" + Email + "'," + SDT + ",N'" + DiaChi + "',N'" + ChucVu + "',CAST(" + Luong + "AS Money))";
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
                MessageBox.Show(ex.Message);
            }
        }
        public void Update(string ID, string Ten, string GioiTinh, string Email, string SDT, string DiaChi, string ChucVu, long Luong)
        {
            sqlQuery = "update NHANVIEN set ID = N'" + ID + "', HoTen = N'" + Ten + "', GioiTinh = N'" +
                GioiTinh + "', Email= N'" + Email + "', SoDT =" + SDT + ", DiaChi = N'" + DiaChi + "', ChucVu=N'" + ChucVu + "', " +
                "Luong = CAST(" + Luong + "AS Money)" + "where ID ='" + ID + "'";
            string str = "update NHANVIEN set ID = N'" + ID + "', HoTen = N'" + Ten + "', GioiTinh = N'" +
                GioiTinh + "', Email= N'" + Email + "', SoDT =" + SDT + ", DiaChi = N'" + DiaChi + "', ChucVu=N'" + ChucVu + "', " +
                "Luong = CAST(" + Luong + "AS Money)" + "where ID ='" + ID + "'";


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
            sqlQuery = "delete from NHANVIEN where ID ='" + ID + "'";
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
        //public DataTable searchData(string keyword)
        //{
        //    sqlQuery = " select * from [TrangThietBi]";
        //    sqlQuery += " WHERE ([ten] LIKE CONCAT('%',@sKeyword,'%'))";
        //    sqlQuery += " OR ([ma] LIKE CONCAT('%',@sKeyword,'%'))";
        //    sqlQuery += " OR ([soLuong] LIKE CONCAT('%',@sKeyword,'%'))";
        //    sqlQuery += " OR ([tinhTrang] LIKE CONCAT('%',@sKeyword,'%'))";

        //    conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
        //    try
        //    {
        //        using (var con = new SqlConnection(constring.initString()))
        //        {
        //            using (var cmd = new SqlCommand(sqlQuery, con))
        //            {
        //                cmd.Parameters.AddWithValue("@sKeyword", keyword);
        //                con.Open();
        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
        //                // this will query your database and return the result to your datatable
        //                da.Fill(result);
        //                con.Close();

        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {

        //    }
        //    return result;
        //}
    }
}
