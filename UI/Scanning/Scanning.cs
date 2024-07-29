
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Gym_management_appication.Class;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI
{
    public partial class Scanning : Form
    {
        private string PrevResult = "";
        private MJPEGStream stream;
        private DataTable result;
        private Database.hoiVien hoiVien = new Database.hoiVien();
        private Database.QuanLyNhanVien.DSNVModel NhanVien = new Database.QuanLyNhanVien.DSNVModel();
        private Database.Attendance attendance = new Database.Attendance();
        private AttendanceClass AttendanceClass = new AttendanceClass();
        Log Log = new Log();

        public Scanning()
        {
            InitializeComponent();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)picCam.Image;
            if (img != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(img);
                try
                {
                    string decoded = result.ToString().Trim();
                    if (decoded == PrevResult) return;
                    if (Checkscan(decoded))
                    {
                        txt_noti.Text = "Scan complete!";
                    }
                    else
                    {
                        //not correct scan
                        txt_noti.Text = "Scan error!";
                    }
                    img.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                stream = new MJPEGStream(tbURLDroidCam.Text);
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                timer1.Enabled = true;
                timer1.Start();
                btnConnect.Text = "Disconnect";
                Log.Insert("Connect camera");
            }
            else
            {
                btnConnect.Text = "Connect";
                timer1.Stop();
                stream.Stop();
                Log.Insert("Disconnect camera");
            }
        }

        public void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picCam.Image = bmp;
        }
        private bool Checkscan(string id)
        {
            if (id.Contains("KH"))
            {
                result = hoiVien.getMemberDetailInfo(id);
                if (result.Rows.Count == 0) return false;
                txt_Alias.Text = "Hội viên";
                label4.Visible = true;
                expireDate.Visible = true;
                PrevResult = id;            
                DateTime expiry = hoiVien.getMemberExpireday(id);
                expireDate.Value = expiry;
                foreach (DataRow row in result.Rows)
                {
                    txt_ID.Text = Convert.ToString(row["ma"]);
                    txt_Name.Text = Convert.ToString(row["ten"]);
                    currentTime.Value = DateTime.Now;
                }
                AttendanceClass.alias = txt_Alias.Text;
                AttendanceClass.attendanceTime = currentTime.Value;
                AttendanceClass.ma = txt_ID.Text;
                attendance.Insert(AttendanceClass);
                Log.Insert("Điểm danh của khách hàng mã "+ txt_ID.Text);
                return true;
            }
            else if (id.Contains("NV"))
            {
                result = NhanVien.getStaffDetailInfo(id);
                if (result.Rows.Count == 0) return false;
                txt_Alias.Text = "Nhân viên";
                label4.Visible = false;
                expireDate.Visible = false;
                PrevResult = id;             
                foreach (DataRow row in result.Rows)
                {
                    txt_ID.Text = Convert.ToString(row["ID"]);
                    txt_Name.Text = Convert.ToString(row["HoTen"]);
                }
                AttendanceClass.alias = txt_Alias.Text;
                AttendanceClass.attendanceTime = currentTime.Value;
                AttendanceClass.ma = txt_ID.Text;
                attendance.Insert(AttendanceClass);
                Log.Insert("Điểm danh");
                return true;
            }
            else return false;
        }
        private void emptytextBox()
        {
            txt_ID.Text = "";
            txt_Name.Text = "";
            txt_Alias.Text = "";
            //timer2.Stop();
        }
    }
}
