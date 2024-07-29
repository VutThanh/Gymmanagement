using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Gym_management_appication.Database.QuanLyHoiVien
{
    public partial class MemberListForm : Form
    {
        Class.hoiVien hoiVien = new Class.hoiVien();
        Log Log = new Log();
        public MemberListForm()
        {
            InitializeComponent();
            LoadMemberListForm();
        }

        private void LoadMemberListForm()
        {
            DataTable dataTable = new DataTable();
            dataTable = new Database.QuanLyHoiVien.DSHVModel().GetData("Select * from Member");
            this.dataGridViewHoiVien.DataSource = dataTable;
            dataGridViewHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            SetHeader();

            //using (MainDataClassesDataContext db = new MainDataClassesDataContext()) {
            //    this.dataGridViewHoiVien.DataSource = from m in db.Members
            //                                          select m;
            //}

            //dataGridViewHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //SetHeader();
        }
        private void SetHeader()
        {
            dataGridViewHoiVien.Columns["ten"].HeaderText = "Tên";
            dataGridViewHoiVien.Columns["ma"].HeaderText = "Mã";
            dataGridViewHoiVien.Columns["tuoi"].HeaderText = "Tuổi";
            dataGridViewHoiVien.Columns["gioiTinh"].HeaderText = "Giới tính";
            dataGridViewHoiVien.Columns["soDT"].HeaderText = "SĐT";
            dataGridViewHoiVien.Columns["ngayThamGia"].HeaderText = "Ngày bắt đầu";
            dataGridViewHoiVien.Columns["ngayKetThuc"].HeaderText = "Ngày kết thúc";

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LoadMemberListForm();
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
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "" || textBoxTen.Text.Trim() == "" || textBoxTuoi.Text.Trim() == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text.Trim() == "") {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            else
            {
                DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("Select ma from Member where ma='" + textBoxID.Text.ToString().Trim() + "'"));
                if (dataTable.Rows.Count == 1) {
                    MessageBox.Show("ID đã tồn tại");
                }
                else
                {

                    Database.QuanLyHoiVien.DSHVModel MemberListFormModel = new Database.QuanLyHoiVien.DSHVModel();
                    hoiVien.ma = textBoxID.Text;
                    hoiVien.ten = textBoxTen.Text;
                    hoiVien.tuoi = Convert.ToInt32( textBoxTuoi.Text.ToString());
                    hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                    hoiVien.sdt = textBoxSDT.Text;
                    hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                    hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;                  
                    try
                    {
                        if (cb_endDayincluded.Checked == true)
                            MemberListFormModel.FullInsert(hoiVien);
                        else
                            MemberListFormModel.Insert(hoiVien);
                        MessageBox.Show("Thêm mới thành công.");
                        Log.Insert("Thêm hội viên " + hoiVien.ma);
                        LoadMemberListForm();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra. Vui Lòng thử lại.");
                    }
                }
            }
        }

        private void DataGridViewHoiVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            textBoxID.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTen.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTuoi.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridViewHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "Nam" || dataGridViewHoiVien.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                radioButtonNam.Checked = true;
            else
                radioButtonNu.Checked = true;
            textBoxSDT.Text = dataGridViewHoiVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePickerNgayThamGia.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[e.RowIndex].Cells[6].Value.ToString());
            try
            {
                dateTimePickerNgayKetThuc.Value = Convert.ToDateTime(dataGridViewHoiVien.Rows[e.RowIndex].Cells[7].Value.ToString());
                cb_endDayincluded.Checked = true;
            }
            catch(Exception ex)
            {
                dateTimePickerNgayKetThuc.Value = DateTime.Today.AddYears(1);
                cb_endDayincluded.Checked = false;
            }            
            hoiVien.ma = textBoxID.Text;
            hoiVien.ten = textBoxTen.Text;
            hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
            hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
            hoiVien.sdt = textBoxSDT.Text;
            hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
            hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxTen.Text == "" || textBoxTuoi.Text == "" || (radioButtonNam.Checked == false && radioButtonNu.Checked == false) || textBoxSDT.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
                return;
            }
            DataTable dataTable = (new Database.QuanLyHoiVien.DSHVModel().GetData("Select ma from Member where ma='" + textBoxID.Text.ToString().Trim() + "'"));
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("ID chưa tồn tại");
            }
            else if (dataTable.Rows.Count == 1)
            {
                hoiVien.ma = textBoxID.Text;
                hoiVien.ten = textBoxTen.Text;
                hoiVien.tuoi = Convert.ToInt32(textBoxTuoi.Text.ToString());
                hoiVien.gioiTinh = (radioButtonNam.Checked ? "Nam" : "Nữ");
                hoiVien.sdt = textBoxSDT.Text;
                hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
                Database.QuanLyHoiVien.DSHVModel MemberListFormModel = new Database.QuanLyHoiVien.DSHVModel();
                try
                {
                    if (cb_endDayincluded.Checked == true)
                        MemberListFormModel.FullUpdate(hoiVien);
                    else
                        MemberListFormModel.Insert(hoiVien);                  
                    MessageBox.Show("Cập nhật thành công.");
                    Log.Insert("Cập nhật thông tin hội viên " + hoiVien.ma);
                    LoadMemberListForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi! Cập nhật thất bại!");
                }
            }
            else
            {

            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn xóa hội viên này ?", "Xóa hội viên", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                Database.QuanLyHoiVien.DSHVModel ds = new Database.QuanLyHoiVien.DSHVModel();
                ds.Delete(hoiVien.ma.ToString().Trim());
                MessageBox.Show("Xóa thành công.");
                Log.Insert("Xóa hội viên " + hoiVien.ma);
                LoadMemberListForm();
            }
        }
        private void TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    

       

        private void showMemberInfo(Member member) {
            if (member != null) {
                textBoxID.Text = member.ma;
                textBoxTen.Text = member.ten;
                textBoxTuoi.Text = member.tuoi.ToString();
                if (member.gioiTinh == "Nam" || member.gioiTinh == "")
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
                textBoxSDT.Text = member.soDT.ToString();
                dateTimePickerNgayThamGia.Value = (DateTime)member.ngayThamGia;
                if (member.ngayKetThuc != null) {
                    dateTimePickerNgayKetThuc.Value = (DateTime)member.ngayKetThuc;
                    cb_endDayincluded.Checked = true;
                }
                else {
                    dateTimePickerNgayKetThuc.Value = DateTime.Today.AddYears(1);
                    cb_endDayincluded.Checked = false;
                }

                // 

                hoiVien.ma = member.ma;
                hoiVien.ten = member.ten;
                hoiVien.tuoi = (int)member.tuoi;
                hoiVien.gioiTinh = member.gioiTinh;
                hoiVien.sdt = textBoxSDT.Text;
                hoiVien.ngayThamGia = dateTimePickerNgayThamGia.Value;
                hoiVien.ngayTKetThuc = dateTimePickerNgayKetThuc.Value;
            }
          
        }
    }
}
