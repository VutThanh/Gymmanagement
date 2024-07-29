using System.Data.SqlClient;
using System.Data;
using System;

namespace Gym_management_appication.Database
{
    class GoiTap
    {
        private string sqlQuery;
        
        private DataTable result = new DataTable();
        public DataTable getPlanList()
        {
            result.Clear();
            sqlQuery = "Select trim(GoiTap.ma) + ' - ' + trim(GoiTap.ten) as List" +
                       " From  GoiTap ";
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
        public int getDuration(string maGoi)
        {
            result.Clear();
            sqlQuery = "select thoiHan from GoiTap where ma = N'" + maGoi + "'";
            int duration = 1;
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
                        duration = (int)cmd.ExecuteScalar();
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return duration;
        }
    }
}
