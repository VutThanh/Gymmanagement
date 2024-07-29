using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database.LichTrucPT;
using Gym_management_appication.UI.LichTrucPT;
using Gym_management_appication.Database.QuanLyNhanVien;
using Gym_management_appication.Class;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI.LichTrucPT
{
    public partial class ThemLichTrucPT : Form
    {
        Log Log = new Log();
        public ThemLichTrucPT()
        {
            InitializeComponent();
            LoadPTName();
        }

        void LoadPTName()
        {
            DataTable nameData = new DataTable();
            nameData = new DSNVModel().GetData("Select * from NHANVIEN where ChucVu = N'PT'");
            for (int i = 0; i < nameData.Rows.Count; i++) {
                comboBoxHoTen.Items.Add(nameData.Rows[i][1].ToString());
            }

        }
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            if (comboBoxHoTen.Text == "" || comboBoxNgayTruc.Text == "" || comboBoxBuoiTruc.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin.");
                return;
            }

            Class.LichTrucPT lichTrucPT = new Class.LichTrucPT();
            data = new DSNVModel().GetData("Select * from NHANVIEN where HoTen = N'" + comboBoxHoTen.Text.Trim() + "' and ChucVu = N'PT'");
            lichTrucPT.ID = data.Rows[0][0].ToString().Trim();
            lichTrucPT.HoTen = this.comboBoxHoTen.Text.Trim();
            lichTrucPT.Thu = Int32.Parse( this.comboBoxNgayTruc.Text.Last().ToString());
            int buoi;
            switch (comboBoxBuoiTruc.Text) {
                case "Buổi sáng":
                    buoi = 1;
                    break;
                case "Buổi chiều":
                    buoi = 2;
                    break;
                case "Buổi tối":
                    buoi = 3;
                    break;
                default:
                    buoi = 1;
                    break;
            }
            lichTrucPT.Buoi = buoi;


            data = new DSNVModel().GetData("Select * from NHANVIEN where ID ='" + lichTrucPT.ID + "'");
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ID không tồn tại");
                return;
            }
            else if (data.Rows.Count == 1)
            {
                if (data.Rows[0][1].ToString().Trim() != lichTrucPT.HoTen.Trim())
                {
                    MessageBox.Show("ID và tên không trùng khớp.");
                    return;
                }
                else
                {
                    if (data.Rows[0][6].ToString().Trim() != "PT") {
                        MessageBox.Show("Nhân viên không phải PT");
                        return;
                    }

                }
            }

            LichTrucPTModel lichTrucPTModel = new LichTrucPTModel();
            data = lichTrucPTModel.GetData("Select * from PTSchedule where Thu =" + lichTrucPT.Thu + " and Buoi =" + lichTrucPT.Buoi +" and ID = N'" + lichTrucPT.ID +"' and HoTen = N'" + lichTrucPT.HoTen+ "'");
            if (data.Rows.Count == 1 && data.Rows[0][1].ToString().Trim() == lichTrucPT.HoTen.Trim()) {
                MessageBox.Show("PT đã trực vào buổi này");
                return;
            }

            try
            {
                lichTrucPTModel.Insert(lichTrucPT);
                MessageBox.Show("Thêm mới thành công");
                Log.Insert("Thêm lịch trực mới cho " + comboBoxHoTen.Text);
                this.Close();
                //LichTrucPT.LoadLichTrucPT();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.");
            }
        }
    }
}
