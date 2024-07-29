using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication.Database.conString
{
    class ConString
    {
        string database;
        string Catalog;
        string userName;//optional
        string password;//optional
        public ConString(string database = @"DESKTOP-GFSAMCK\VUTHANH", string Catalog = "GymManagement", string userName = "None", string password = "None")
        {
            this.database = Class.valiballecommon.GetStorage().DatabaseName.Trim() != "" ? Class.valiballecommon.GetStorage().DatabaseName: database;
            this.Catalog = Catalog;
            this.password = password;
            this.userName = userName;
        }
        public string initString()
        {
            string conString;
            if (this.userName == "None" && this.userName == "None")
                //Data Source=LAPTOP-R6QTHA7P\SQLEXPRESS;Initial Catalog=GymManagement;Integrated Security=True
                conString = @"Data Source=" + database + ";Initial Catalog=" + Catalog + ";Integrated Security=True";
            else
                conString = @"Data Source=" + database + ";Initial Catalog=" + Catalog + ";User ID=" + userName + ";Password=" + password;
            return conString;
        }
    }
}
