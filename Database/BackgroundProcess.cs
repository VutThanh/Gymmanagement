using System.Data.SqlClient;
using System.Data;
using System;


namespace Gym_management_appication.Database
{
    class BackgroundProcess
    {
        private string sqlQuery;
        public void Deleteinactive()
        {           
            sqlQuery = "Delete from Member where ma in (Select ma from Member Where dateadd(yy,-2,getdate()) > ngayKetThuc)";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        con.Close();

                    }
                }
            }
            catch (SqlException ex)
            {

            }           
        }
        public void MakememberInactive()
        {
            sqlQuery = "Update Member set ngayKetThuc = getdate()" +
                "where ma in (select ma from Attendance group by ma having dateadd(yy,-1,getdate()) > max(thoigian))";
            conString.ConString constring = new conString.ConString();    //this will hide the database info ... sort of                
            try
            {
                using (var con = new SqlConnection(constring.initString()))
                {
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
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
