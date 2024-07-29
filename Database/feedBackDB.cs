using System.Data.SqlClient;
using System.Data;
using System;
using Gym_management_appication.Class;

namespace Gym_management_appication.Database
{
    class feedBackDB
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public bool Insert(feedBack feedback)
        {
            sqlQuery = "insert into Feedback (maKH,thoigian,feedback)" +
                       " values('" + feedback.maHV + "', '" + feedback.date + "', N'" + feedback.feedback + "')";
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
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
        public DataTable getData()
        {
            sqlQuery = " select * from [Feedback]";

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
