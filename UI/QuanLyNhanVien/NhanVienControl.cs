using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management_appication.UI
{
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }

        private void RadioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNu.Checked == true)
                this.radioButtonNam.Checked = false;
        }

        private void RadioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNam.Checked == true)
                this.radioButtonNu.Checked = false;
        }

        private void TextBoxLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void SetControlsData(string ID, string Ten,string GioiTinh, string Email, string SDT, string DiaChi, string ChucVu, long Luong ) {
            this.textBoxID.Text = ID.Trim();
            this.textBoxTen.Text = Ten.Trim();
            if (GioiTinh.Trim() == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
                radioButtonNu.Checked = true;
            this.textBoxEmail.Text = Email.Trim();
            this.textBoxSDT.Text = SDT.Trim();
            this.textBoxDiaChi.Text = DiaChi.Trim();
            this.textBoxChucVu.Text = ChucVu.Trim();
            this.textBoxLuong.Text = Luong.ToString().Trim();
        }

        public bool CheckData() {
            if (textBoxID.Text.ToString() != "" && textBoxTen.Text.ToString() != ""&& (radioButtonNam.Checked|| radioButtonNu.Checked) && textBoxEmail.Text.ToString() != "" && textBoxSDT.Text.ToString() != "" && textBoxDiaChi.Text.ToString() != "" && textBoxChucVu.Text.ToString() != "" && textBoxLuong.Text.ToString() != "")
                return true;
            else
                return false;
        }

        public string GetID() {
            return textBoxID.Text.ToString().Trim();
        }
        public string GetTen()
        {
            return textBoxTen.Text.ToString().Trim();
        }
        public string GetGioiTinh()
        {
            if (radioButtonNam.Checked)
                return "Nam";
            else
                return "Nu";
        }

        public string GetEmail()
        {
            return textBoxEmail.Text.ToString().Trim();
        }
        public string GetDiaChi() {
            return textBoxDiaChi.Text.ToString();
        }
        public string GetSDT()
        {
            return textBoxSDT.Text.ToString().Trim();
        }
        public string GetChucVu()
        {
            return textBoxChucVu.Text.ToString().Trim();
        }
        public long GetLuong()
        {
            return Convert.ToInt64(textBoxLuong.Text.ToString().Trim());
        }

        public void SetID(string ID) {
            this.textBoxID.Text = ID;
        }
    }
}
