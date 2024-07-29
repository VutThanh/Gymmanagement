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

namespace Gym_management_appication.UI.QuanLyNhanVien
{
    public partial class TaoTaiKhoanDangNhap : Form
    {
        Log log = new Log();
        public TaoTaiKhoanDangNhap(string maNV)
        {
            InitializeComponent();
            txt_manv.Text = maNV;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            switch (txt_level.Value)
            {
                case 1:
                    txt_levelName.Text = "Admin";
                    break;
                case 2:
                    txt_levelName.Text = "Owner";
                    break;
                case 3:
                    txt_levelName.Text = "Receptionist";
                    break;
                case 4:
                    txt_levelName.Text = "PT";
                    break;
                default:
                    txt_level.Value = 1;
                    txt_levelName.Text = "Admin";
                    break;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txt_username.Text.Trim() == "")
            {
                MessageBox.Show("Nhập username!");
            }
            if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Nhập password!");
            }
            DialogResult dialogResult = MessageBox.Show("Xác nhận tạo tài khoản?", "Xác nhận!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Database.LogIn login = new Database.LogIn();
                string userName = txt_username.Text.ToLower();
                login.Insert(txt_manv.Text, (int)txt_level.Value, userName, txt_password.Text);
                log.Insert("Tạo tài khoản đăng nhập cho nhân viên "+ txt_manv.Text);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void cb__CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_showPass.Checked ? '\0' : '*';
        }

        private void TaoTaiKhoanDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
