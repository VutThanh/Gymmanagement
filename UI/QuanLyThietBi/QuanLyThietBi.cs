using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database;

namespace Gym_management_appication.UI
{
    public partial class QuanLyThietBi : Form
    {
        Log Log = new Log();
        public QuanLyThietBi()
        {
            InitializeComponent();
        }

        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            trangThietBi data = new trangThietBi();
            DataTable thietbiList = data.getData();
            dtgv_ThietBiList.DataSource = thietbiList;
            SetHeader();
        }
        private void SetHeader()
        {
            dtgv_ThietBiList.Columns["ten"].HeaderText = "Tên";
            dtgv_ThietBiList.Columns["ma"].HeaderText = "Mã";
            dtgv_ThietBiList.Columns["tinhTrang"].HeaderText = "Tình Trạng";
            dtgv_ThietBiList.Columns["ngayMua"].Visible = false;
            dtgv_ThietBiList.Columns["giaThanh"].Visible = false;
            dtgv_ThietBiList.Columns["baoHanh"].Visible = false;
            dtgv_ThietBiList.Columns["ngayHetHanBaoHanh"].Visible = false;
            dtgv_ThietBiList.Columns["hangSanXuat"].Visible = false;
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.trangThietBi thietBi = new Class.trangThietBi();
            int currentRowIndex = dtgv_ThietBiList.CurrentCellAddress.Y;// 'current row selected
            if (-1 < currentRowIndex && currentRowIndex < dtgv_ThietBiList.RowCount)
            {
                thietBi.ten = dtgv_ThietBiList.Rows[currentRowIndex].Cells["ten"].Value.ToString();
                thietBi.ma = dtgv_ThietBiList.Rows[currentRowIndex].Cells["ma"].Value.ToString();               
                thietBi.tinhTrang = dtgv_ThietBiList.Rows[currentRowIndex].Cells["tinhTrang"].Value.ToString();
                //invisible part---------
                thietBi.ngayMua = Convert.ToDateTime(dtgv_ThietBiList.Rows[currentRowIndex].Cells["ngayMua"].Value.ToString());
                thietBi.giaThanh = int.Parse(dtgv_ThietBiList.Rows[currentRowIndex].Cells["giaThanh"].Value.ToString());
                thietBi.baoHanh = int.Parse(dtgv_ThietBiList.Rows[currentRowIndex].Cells["baoHanh"].Value.ToString());
                thietBi.ngayHetHanBaoHanh = Convert.ToDateTime(dtgv_ThietBiList.Rows[currentRowIndex].Cells["ngayHetHanBaoHanh"].Value.ToString());
                thietBi.hangSanXuat = dtgv_ThietBiList.Rows[currentRowIndex].Cells["hangSanXuat"].Value.ToString();
            }
            ChiTietThietBi chiTietThietBi = new ChiTietThietBi(thietBi);
            chiTietThietBi.ShowDialog();
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dtgv_ThietBiList.DataSource = null;
            trangThietBi trangThietBi = new trangThietBi();
            DataTable thietbiList = trangThietBi.searchData(txt_search.Text);
            dtgv_ThietBiList.DataSource = thietbiList;
            SetHeader();
        }


        private void xóaThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận xóa thiết bị này khỏi danh sách?", "Caution!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Class.trangThietBi thietBi = new Class.trangThietBi();
                int currentRowIndex = dtgv_ThietBiList.CurrentCellAddress.Y;// 'current row selected
                if (-1 < currentRowIndex && currentRowIndex < dtgv_ThietBiList.RowCount)
                {
                    thietBi.ten = dtgv_ThietBiList.Rows[currentRowIndex].Cells["ten"].Value.ToString();
                    thietBi.ma = dtgv_ThietBiList.Rows[currentRowIndex].Cells["ma"].Value.ToString();                 
                    thietBi.tinhTrang = dtgv_ThietBiList.Rows[currentRowIndex].Cells["tinhTrang"].Value.ToString();
                }
                trangThietBi trangThietBi = new trangThietBi();
                trangThietBi.deleteData(thietBi);
                Log.Insert("Xóa thông tin thiết bị " + thietBi.ten);
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietThietBi chiTietThietBi = new ChiTietThietBi();
            chiTietThietBi.ShowDialog();
            LoadData();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtgv_ThietBiList.DataSource = null;
                trangThietBi trangThietBi = new trangThietBi();
                DataTable thietbiList = trangThietBi.searchData(txt_search.Text);
                dtgv_ThietBiList.DataSource = thietbiList;
                SetHeader();
            }
        }
    }
}
