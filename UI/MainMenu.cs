using System;
using Gym_management_appication.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database.QuanLyHoiVien;
using Gym_management_appication.UI;
using Gym_management_appication.UI.ThongKeHoiVien;
using Gym_management_appication.Database;
using System.Data.SqlClient;

namespace Gym_management_appication.UI
{
    public partial class MainMenu : Form
    {
        private int permissionlevel;
        Log log = new Log();
        public MainMenu()
        {
            InitializeComponent();
            hideSubMenu();
            valiballecommon valiballecommon = valiballecommon.GetStorage();
            permissionlevel = valiballecommon.Permission;
            disableButton();
        }
        private void disableButton()
        {
           switch (permissionlevel)
            {
                case 1:
                    break;
                case 2:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_Danhsach.Enabled = false;
                    btn_attendance.Enabled = false;
                    break;
                case 3:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_QuanLyHoiVien.Enabled = false;
                    btn_attendance.Enabled = false;
                    btn_QuanLyThietbi.Enabled = false;
                    btn_QuanLyDoanhThu.Enabled = false;
                    break;
                case 4:
                    btn_QuanLyNhanvien.Enabled = false;
                    btn_QuanLyHoiVien.Enabled = false;
                    btn_attendance.Enabled = false;
                    btn_QuanLyThietbi.Enabled = false;
                    btn_QuanLyDoanhThu.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Thông tin đăng nhập lỗi", "Error");
                    this.Close();
                    break;
            }    
        }
        private void hideSubMenu()
        {
            GroupQuanLyHoiVien.Visible = false;
            GroupQuanLyNhanVien.Visible = false;
            GroupQuanLyDoanhThu.Visible = false;
            //Add more Group of Form 
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }      

        #region QuanLyHoiVien
        private void btn_QuanLyHoiVien_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyHoiVien);
        }
        private void btn_Danhsach_Click(object sender, EventArgs e)
        {
            openChildForm(new MemberListForm());

            hideSubMenu();
        }

   
        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            openChildForm(new UI.QuanLyHoiVien.DangKyHoiVien());

            hideSubMenu();
        }

        #endregion

        #region QuanLyDoanhThu
        private void btn_QuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyDoanhThu);
        }

       
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThanhToan());

            hideSubMenu();
        }
        #endregion

        #region QuanLyNhanVien
        private void btn_QuanLyNhanvien_Click(object sender, EventArgs e)
        {
            showSubMenu(GroupQuanLyNhanVien);
            
        }

        private void btn_DsNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachNhanVien());

            hideSubMenu();
        }

        private void btn_LichTrucPT_Click(object sender, EventArgs e)
        {
            openChildForm(new LichTrucPT.LichTrucPT());

            hideSubMenu();
        }

        #endregion

        private void btn_QuanLyThietbi_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyThietBi());

            hideSubMenu();
        }
        private void btn_Scan_Click(object sender, EventArgs e)
        {
            openChildForm(new Scanning());

            hideSubMenu();
        }
        private void btn_attendance_Click(object sender, EventArgs e)
        {
            openChildForm(new Attendance());

            hideSubMenu();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            container.Controls.Add(childForm);
            container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            BW.RunWorkerAsync();
        }

        private void BW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Check the database connection 
            valiballecommon valiballecommon = valiballecommon.GetStorage();
            Properties.Settings setting = Properties.Settings.Default;
            string concheck = "Data Source = " + valiballecommon.DatabaseName + "; Initial Catalog= GymManagement;  Integrated Security=True";
            
            SqlConnection con = new SqlConnection(concheck);
            try
            {
                con.Open();
                con.Close();
            }catch (Exception ex)
            {
                throw ex;
            }
            //Delete old member
            BackgroundProcess backgroundProcess = new BackgroundProcess();
            backgroundProcess.MakememberInactive();
            backgroundProcess.Deleteinactive();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var form1 = new Login();
            log.Insert("Logout");
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void logoPanel_Click(object sender, EventArgs e)
        {
            if (permissionlevel == 1)
            {
                openChildForm(new Loghistory());
                hideSubMenu();
            }
        }


        private void BW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //throw e.Error;
                notifyIcon1.Text = e.Error.ToString();
            }
            else
            {
                notifyIcon1.Text = "Dữ liệu đã được cập nhật";
            }
            notifyIcon1.ShowBalloonTip(5);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void GroupQuanLyHoiVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
