using System.Data.SqlClient;
using System.Data;
using System;

namespace Gym_management_appication.Database
{
    class DoanhThu
    {
        private string sqlQuery;
        private DataTable result = new DataTable();
        public DataTable getIncomeofMonth(DateTime fromDate, DateTime toDate)
        {
            result.Clear();
            sqlQuery = "SELECT cast(month(dateOfPay) as varchar) + '/' + cast(year(dateOfPay) as varchar) as SalesMonth," +
                       " SUM(price) AS TotalSales" +
                       " FROM MonthlyIncome" +
                       " WHERE dateOfPay >= '" + fromDate + "' AND dateOfPay <= '" + toDate + "'" +
                       " GROUP BY YEAR(dateOfPay), MONTH(dateOfPay)" +
                       " ORDER BY YEAR(dateOfPay), MONTH(dateOfPay)";
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
        public DataTable getIncomeofYear(DateTime fromDate, DateTime toDate)
        {
            result.Clear();
            sqlQuery = "SELECT YEAR(dateOfPay) as SalesYear, SUM(price) AS TotalSales" +
                       " FROM MonthlyIncome" +
                       " WHERE dateOfPay >= '" + fromDate + "' AND dateOfPay <= '" + toDate + "'" +
                       " GROUP BY YEAR(dateOfPay)" +
                       " ORDER BY YEAR(dateOfPay)";
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
