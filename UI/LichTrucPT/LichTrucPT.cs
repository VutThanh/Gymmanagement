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
using Gym_management_appication.Database.LichTrucPT;
using Gym_management_appication.UI.LichTrucPT;


namespace Gym_management_appication.UI.LichTrucPT
{
    public partial class LichTrucPT : Form
    {

        public static DataTable dataTable = new DataTable();
        public LichTrucPT()
        {
            InitializeComponent();
            LoadLichTrucPT();
        }
        public void LoadLichTrucPT() {
            ClearAllControlData();
            dataTable = new LichTrucPTModel().GetData("Select * from PTSchedule");
            resolveData();
        }
        public  void ClearAllControlData() {
            panel21.Controls.Clear();
            panel22.Controls.Clear();
            panel23.Controls.Clear();
            panel31.Controls.Clear();
            panel32.Controls.Clear();
            panel33.Controls.Clear();
            panel41.Controls.Clear();
            panel42.Controls.Clear();
            panel43.Controls.Clear();
            panel51.Controls.Clear();
            panel52.Controls.Clear();
            panel53.Controls.Clear();
            panel61.Controls.Clear();
            panel62.Controls.Clear();
            panel63.Controls.Clear();
            panel71.Controls.Clear();
            panel72.Controls.Clear();
            panel73.Controls.Clear();
        }
        public  void resolveData() {
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Label lb = new Label();
                lb.Text = dataTable.Rows[i][1].ToString();
                lb.Font = new Font("Microsoft Sans Serif", 10);
                lb.AutoSize = true;
                lb.BackColor = Color.FromArgb(254, 129, 118);
                lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                switch (dataTable.Rows[i][2]) {
                    case 2:
                        switch (dataTable.Rows[i][3]) {
                            case 1:
                                panel21.Controls.Add(lb);
                                break;
                            case 2:
                                panel22.Controls.Add(lb);
                                break;
                            case 3:
                                panel23.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 3:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel31.Controls.Add(lb);
                                break;
                            case 2:
                                panel32.Controls.Add(lb);
                                break;
                            case 3:
                                panel33.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 4:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel41.Controls.Add(lb);
                                break;
                            case 2:
                                panel42.Controls.Add(lb);
                                break;
                            case 3:
                                panel43.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 5:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel51.Controls.Add(lb);
                                break;
                            case 2:
                                panel52.Controls.Add(lb);
                                break;
                            case 3:
                                panel53.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 6:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel61.Controls.Add(lb);
                                break;
                            case 2:
                                panel62.Controls.Add(lb);
                                break;
                            case 3:
                                panel63.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 7:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel71.Controls.Add(lb);
                                break;
                            case 2:
                                panel72.Controls.Add(lb);
                                break;
                            case 3:
                                panel73.Controls.Add(lb);
                                break;
                        }
                        break;                  
                }
            }

        }

        private void ButtonThemLich_Click(object sender, EventArgs e)
        {
            ThemLichTrucPT themLichTrucPT = new ThemLichTrucPT();
            themLichTrucPT.FormClosed += new FormClosedEventHandler(child_FormClosed);
            themLichTrucPT.ShowDialog();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            LoadLichTrucPT();
        }
        private void ButtonXoaLich_Click(object sender, EventArgs e)
        {
            XoaLichTrucPT xoaLichTrucPT = new XoaLichTrucPT();
            xoaLichTrucPT.FormClosed += new FormClosedEventHandler(child_FormClosed);
            xoaLichTrucPT.ShowDialog();
        }
    }
}
