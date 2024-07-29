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
    public partial class Attendance : Form
    {
        private Database.Attendance attendance = new Database.Attendance();
        private Class.AttendanceClass AttendanceClass = new Class.AttendanceClass();
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            DataTable attendanceList = attendance.getData();
            dtg_attendanceList.DataSource = attendanceList;
            SetHeader();
        }
        private void SetHeader()
        {
            dtg_attendanceList.Columns["ma"].HeaderText = "Mã";
            dtg_attendanceList.Columns["thoigian"].HeaderText = "Thời gian";
            dtg_attendanceList.Columns["alias"].HeaderText = "Chức vụ";
        }
        private void btn_searchkeyw_Click(object sender, EventArgs e)
        {
            dtg_attendanceList.DataSource = null;
            DataTable attendanceList = attendance.searchData(txt_keyword.Text);
            dtg_attendanceList.DataSource = attendanceList;
            SetHeader();
        }

        private void btn_searchtimespan_Click(object sender, EventArgs e)
        {
            if(fromTime.Value > toTime.Value)
            {
                MessageBox.Show("Mốc thời gian không hợp lệ!", "Error!");
                return;
            }
            else
            {
                dtg_attendanceList.DataSource = null;
                DataTable attendanceList = attendance.searchDataintimespan(fromTime.Value,toTime.Value);
                dtg_attendanceList.DataSource = attendanceList;
                SetHeader();
            }
        }

        private void txt_keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtg_attendanceList.DataSource = null;
                DataTable attendanceList = attendance.searchData(txt_keyword.Text);
                dtg_attendanceList.DataSource = attendanceList;
                SetHeader();
            }
        }
    }
}
