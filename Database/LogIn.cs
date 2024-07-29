using System;
using System.Data.SqlClient;
using System.Data;

namespace Gym_management_appication.Database
{
    class LogIn
    {
        private string sqlQuery;
        private bool result;
        private int permission;
        private string ID;
        public bool getRefication(string UserName, string password)
        {
            sqlQuery = "SELECT CASE WHEN EXISTS ( " +
                       "SELECT * FROM LogInData " +
                       "WHERE username = '" + UserName + "' and passW = '" + password + "') " +
                       "THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        //con.Open();
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //// this will query your database and return the result to your datatable

                        //con.Close();

                        con.Open();
                        result = (bool)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                //con.Close();
            }
            return result;
        }

        public string getID(string UserName)
        {
            sqlQuery = "Select NHANVIEN.ID from NHANVIEN inner join LogInData on NHANVIEN.ID = LogInData.ma " +
                       "where LogInData.username = '" + UserName + "'";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        //con.Open();
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //// this will query your database and return the result to your datatable

                        //con.Close();

                        con.Open();
                        ID = cmd.ExecuteScalar().ToString();
                        con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                //con.Close();
            }
            return ID;
        }
        public int getPermission(string UserName)
        {
            sqlQuery = "Select LogInData.permissionLevel from LogInData where LogInData.username =  '" + UserName + "'";
            
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        //con.Open();
                        //SqlDataAdapter da = new SqlDataAdapter(cmd);
                        //// this will query your database and return the result to your datatable

                        //con.Close();

                        con.Open();
                        permission = (int)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                //con.Close();
            }
            return permission;
        }
        public void Insert(string maNV, int level, string UserName, string pass)
        {
            sqlQuery = "INSERT INTO LogInData (maNV, permissionLevel, username, passW) VALUES ('" + maNV + "'," + level + ",'" + UserName + "','" + pass + "')";
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
    }
}
