using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Class;



namespace Gym_management_appication.UI
{
    public partial class ChiTietThietBi : Form
    {
        Database.Log log = new Database.Log();
        public ChiTietThietBi(trangThietBi trangThietBi)
        {          
            InitializeComponent();
            txt_Ten.Text = trangThietBi.ten;
            txt_Ma.Text = trangThietBi.ma;
            cb_tinhTrang.Text = trangThietBi.tinhTrang;
            dT_ngayMua.Value = trangThietBi.ngayMua;
            UD_giaThanh.Value = trangThietBi.giaThanh;
            UD_baoHanh.Value = trangThietBi.baoHanh;
            dT_ngayHetHan.Value = trangThietBi.ngayHetHanBaoHanh;
            txt_hangSX.Text = trangThietBi.hangSanXuat;
            txt_Ma.ReadOnly = true;             
            btn_Sua.Text = "Sửa";

        }
        public ChiTietThietBi()
        {
            InitializeComponent();
            txt_Ma.ReadOnly = false;
            btn_Sua.Text = "Thêm";
        }
        

        private void ChiTietThietBi_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!checknull())
            {
                return;
            }
            trangThietBi trangThietBi = new trangThietBi();
            trangThietBi.ten = txt_Ten.Text;
            trangThietBi.ma = txt_Ma.Text;
            trangThietBi.tinhTrang = cb_tinhTrang.Text;
            trangThietBi.ngayMua = dT_ngayMua.Value;
            trangThietBi.giaThanh = (int)UD_giaThanh.Value;
            trangThietBi.baoHanh = (int)UD_baoHanh.Value;
            trangThietBi.ngayHetHanBaoHanh = dT_ngayHetHan.Value;
            trangThietBi.hangSanXuat = txt_hangSX.Text;
            Database.trangThietBi data = new Database.trangThietBi();
            if ("Thêm" == btn_Sua.Text)
            {
                data.insertData(trangThietBi);
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Gym_management_appication.Properties.Settings.GymManagementConnectionString"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "themthietbi";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value =txt_Ten.Text;
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value =txt_Ma.Text;
                cmd.Parameters.Add("@tinhTrang", SqlDbType.NVarChar).Value = cb_tinhTrang.Text;
                cmd.Parameters.Add("@ngayMua", SqlDbType.DateTime).Value = DateTime.Parse(dT_ngayMua.Value.ToString());
                cmd.Parameters.Add("@giaThanh", SqlDbType.Int).Value = Int32.Parse(UD_giaThanh.Value.ToString());
                cmd.Parameters.Add("@baoHanh", SqlDbType.Int).Value = Int32.Parse(UD_baoHanh.Value.ToString());
                cmd.Parameters.Add("@ngayHetHanBaoHanh", SqlDbType.DateTime).Value = DateTime.Parse(dT_ngayHetHan.Value.ToString());
                cmd.Parameters.Add("@hangSanXuat", SqlDbType.NVarChar).Value = txt_hangSX.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thiết bị đã đươc thêm!", "Success");
                log.Insert("Thêm thiết bị " + trangThietBi.ten);
            }
            else if ("Sửa" == btn_Sua.Text)
            {
                data.updateData(trangThietBi);
                MessageBox.Show("Thiết bị đã đươc chỉnh sửa!", "Success");
                log.Insert("Chỉnh sửa thông tin thiết bị " + trangThietBi.ten);
            }
            this.Close();
        }
        private bool checknull()
        {
            if(txt_Ten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thiết bị!", "Warning!");
                txt_Ten.Select();
                return false;
            }
            if (txt_Ma.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị!", "Warning!");
                txt_Ma.Select();
                return false;
            }
            if( cb_tinhTrang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn tình trạng của thiết bị!", "Warning!");
                cb_tinhTrang.Select();
                return false;
            }            
            return true;
        }

        private void dT_ngayMua_ValueChanged(object sender, EventArgs e)
        {
            dT_ngayHetHan.Value = dT_ngayMua.Value.AddMonths((int)UD_baoHanh.Value);
        }

        private void UD_baoHanh_ValueChanged(object sender, EventArgs e)
        {
            dT_ngayHetHan.Value = dT_ngayMua.Value.AddMonths((int)UD_baoHanh.Value);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
