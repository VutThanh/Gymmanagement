using Gym_management_appication.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gym_management_appication.UI.QuanLyHoiVien
{
    public partial class DangKyHoiVien : Form
    {
        Class.hoiVien hoiVien = new Class.hoiVien();
        Log log = new Log();
        public DangKyHoiVien()
        {
            InitializeComponent();
            SetAutoGenerateID();
        }

        private void SetAutoGenerateID()
        {
            textBoxID.Text = autoGenerateID();
        }
        private string autoGenerateID()
        {
            DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("SELECT MAX(dbo.udf_GetNumeric(Member.ma)) from Member"));
            int lastID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            lastID++;
            string num = lastID.ToString().PadLeft(3, '0');
            return "KH" + num;
        }
        private void RadioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNam.Checked == true)
                this.radioButtonNu.Checked = false;
        }

        private void RadioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonNu.Checked == true)
                this.radioButtonNam.Checked = false;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "" || textBoxTen.Text.Trim() == "" || textBoxTuoi.Text.Trim() == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text.Trim() == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            else
            {
                DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("Select ma from Member where ma='" + textBoxID.Text.ToString().Trim() + "'"));
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("ID đã tồn tại");
                }
                else
                {

                    Database.QuanLyHoiVien.DSHVModel MemberModel = new Database.QuanLyHoiVien.DSHVModel();
                    hoiVien.ma = textBoxID.Text;
                    hoiVien.ten = textBoxTen.Text;
                    hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
                    hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                    hoiVien.sdt = textBoxSDT.Text;
                    hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                    try
                    {
                        MemberModel.Insert(hoiVien);
                        MessageBox.Show("Đăng ký thành công.");
                        log.Insert("Thêm hội viên " + hoiVien.ma);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra. Vui Lòng thử lại.");
                    }
                }
            }
        }
    }
}
