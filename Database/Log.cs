using System.Data.SqlClient;
using Gym_management_appication.Class;
using System.Data;
using System;

namespace Gym_management_appication.Database
{
    class Log
    {
        private string sqlQuery;
        public void Insert(string task)
        {
            valiballecommon valiballecommon = valiballecommon.GetStorage();
            sqlQuery = "insert into Log (username, thoigian, task) values ('" + 
                valiballecommon.UserName + "',N'" + DateTime.Now + "', N'" + task + "')";
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
        public DataTable getData()
        {
            DataTable result = new DataTable();
            sqlQuery = "select * from [Log]";
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
