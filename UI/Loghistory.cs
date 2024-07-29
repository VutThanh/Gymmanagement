using Gym_management_appication.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI
{
    public partial class Loghistory : Form
    {
        public Loghistory()
        {
            InitializeComponent();
        }

        private void Loghistory_Load(object sender, EventArgs e)
        {
            Log data = new Log();
            DataTable logList = data.getData();
            Logdata.DataSource = logList;
            SetHeader();
        }
        private void SetHeader()
        {
            Logdata.Columns["username"].HeaderText = "Tài khoản";
            Logdata.Columns["thoigian"].HeaderText = "Thời gian";
            Logdata.Columns["task"].HeaderText = "Task";
        }
    }
}
