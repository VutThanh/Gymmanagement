using Gym_management_appication.Database;
using Gym_management_appication.Class;
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
    public partial class Login : Form
    {
        Log Log = new Log();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Properties.Settings setting = Properties.Settings.Default;
            txt_DB.Text = setting.DatabaseName;
            if (setting.UserName == "")
                txt_userName.Text = "User name";
            else
            {
                txt_userName.Text = setting.UserName;
                txt_pass.Select();
            }
            if (setting.tickedCheck == true)
                chB_saveUser.Checked = true;
            else
                chB_saveUser.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryLogin();
        }

        private void tryLogin()
        {
            Properties.Settings setting = Properties.Settings.Default;
            valiballecommon valiballecommon = valiballecommon.GetStorage();
            valiballecommon.DatabaseName = txt_DB.Text;

            LogIn login = new LogIn();
            if (!login.getRefication(txt_userName.Text.Trim().ToLower(), txt_pass.Text.Trim()))
            {
                MessageBox.Show("Tên đắng nhập hoặc mật khẩu sai!", "Error!");
            }
            else
            {
                valiballecommon.UserName = txt_userName.Text;
                valiballecommon.Permission = login.getPermission(txt_userName.Text.Trim().ToLower());
                valiballecommon.UserCode = login.getID(txt_userName.Text.Trim().ToLower());
                valiballecommon.DatabaseName = txt_DB.Text;
                setting.DatabaseName = valiballecommon.DatabaseName;
                if (chB_saveUser.Checked == true)
                    setting.UserName = txt_userName.Text;
                else
                    setting.UserName = "";
                setting.Save();
                Log.Insert("Login");
                this.Hide();
                var form2 = new MainMenu();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void txt_userName_Enter(object sender, EventArgs e)
        {
            if (txt_userName.Text == "User name")
            {
                txt_userName.Text = "";
            }
        }

        private void txt_userName_Leave(object sender, EventArgs e)
        {
            if (txt_userName.Text.Trim() == "")
            {
                txt_userName.Text = "User name";
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.PasswordChar = '*';
                txt_pass.Text = "";
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim() == "")
            {
                txt_pass.PasswordChar = '\0';
                txt_pass.Text = "Password";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_DB.Text == "Database Name")
            {                
                txt_DB.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_DB.Text.Trim() == "")
            {
                txt_DB.Text = "Database Name";
            }
        }

        private void chB_saveUser_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings setting = Properties.Settings.Default;
            if(chB_saveUser.Checked == false)
                setting.tickedCheck = false;
            else
                setting.tickedCheck = true;
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tryLogin();
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
