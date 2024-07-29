using System.Data.SqlClient;
using System.Data;
using System;
using Gym_management_appication.Class;

namespace Gym_management_appication.Database
{
    class Attendance
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public void Insert(AttendanceClass attendanceClass)
        {
            sqlQuery = "insert into Attendance (ma,thoigian, alias) " +
                       " values ('"+ attendanceClass.ma + "','"+ attendanceClass.attendanceTime + "', N'"+ attendanceClass.alias + "')";
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
        public DataTable getData()
        {
            sqlQuery = " select * from [Attendance]";

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
        public DataTable searchData(string keyword)
        {
            result.Clear();
            sqlQuery = " select * from [Attendance]";
            sqlQuery += " WHERE ([ma] LIKE CONCAT('%','" + keyword + "','%'))";
            sqlQuery += " OR ([alias] LIKE CONCAT('%','" + keyword + "','%'))";

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
        public DataTable searchDataintimespan(DateTime from, DateTime to)
        {
            result.Clear();
            sqlQuery = " select * from [Attendance]";
            sqlQuery += " WHERE thoigian BETWEEN '" + from + "' AND '" + to + "';";
            
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
    }
}
