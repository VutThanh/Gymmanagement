
namespace Gym_management_appication.UI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Phanhoi = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.GroupQuanLyDoanhThu = new System.Windows.Forms.Panel();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.btn_QuanLyDoanhThu = new System.Windows.Forms.Button();
            this.btn_QuanLyThietbi = new System.Windows.Forms.Button();
            this.GroupQuanLyNhanVien = new System.Windows.Forms.Panel();
            this.btn_LichTrucPT = new System.Windows.Forms.Button();
            this.btn_DsNhanVien = new System.Windows.Forms.Button();
            this.btn_QuanLyNhanvien = new System.Windows.Forms.Button();
            this.GroupQuanLyHoiVien = new System.Windows.Forms.Panel();
            this.btn_Dangky = new System.Windows.Forms.Button();
            this.btn_Danhsach = new System.Windows.Forms.Button();
            this.btn_QuanLyHoiVien = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sidePanel.SuspendLayout();
            this.GroupQuanLyDoanhThu.SuspendLayout();
            this.GroupQuanLyNhanVien.SuspendLayout();
            this.GroupQuanLyHoiVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(179)))));
            this.sidePanel.Controls.Add(this.btn_logout);
            this.sidePanel.Controls.Add(this.btn_Phanhoi);
            this.sidePanel.Controls.Add(this.btn_attendance);
            this.sidePanel.Controls.Add(this.GroupQuanLyDoanhThu);
            this.sidePanel.Controls.Add(this.btn_QuanLyDoanhThu);
            this.sidePanel.Controls.Add(this.btn_QuanLyThietbi);
            this.sidePanel.Controls.Add(this.GroupQuanLyNhanVien);
            this.sidePanel.Controls.Add(this.btn_QuanLyNhanvien);
            this.sidePanel.Controls.Add(this.GroupQuanLyHoiVien);
            this.sidePanel.Controls.Add(this.btn_QuanLyHoiVien);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 840);
            this.sidePanel.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(0, 854);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(250, 80);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Phanhoi
            // 
            this.btn_Phanhoi.Location = new System.Drawing.Point(0, 0);
            this.btn_Phanhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Phanhoi.Name = "btn_Phanhoi";
            this.btn_Phanhoi.Size = new System.Drawing.Size(67, 18);
            this.btn_Phanhoi.TabIndex = 17;
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_attendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_attendance.Location = new System.Drawing.Point(0, 774);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(250, 80);
            this.btn_attendance.TabIndex = 14;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // GroupQuanLyDoanhThu
            // 
            this.GroupQuanLyDoanhThu.Controls.Add(this.btn_thanhToan);
            this.GroupQuanLyDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupQuanLyDoanhThu.Location = new System.Drawing.Point(0, 672);
            this.GroupQuanLyDoanhThu.Name = "GroupQuanLyDoanhThu";
            this.GroupQuanLyDoanhThu.Size = new System.Drawing.Size(250, 102);
            this.GroupQuanLyDoanhThu.TabIndex = 12;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btn_thanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thanhToan.FlatAppearance.BorderSize = 0;
            this.btn_thanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.Location = new System.Drawing.Point(0, 0);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_thanhToan.Size = new System.Drawing.Size(250, 50);
            this.btn_thanhToan.TabIndex = 1;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // btn_QuanLyDoanhThu
            // 
            this.btn_QuanLyDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_QuanLyDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyDoanhThu.FlatAppearance.BorderSize = 0;
            this.btn_QuanLyDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyDoanhThu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLyDoanhThu.Location = new System.Drawing.Point(0, 592);
            this.btn_QuanLyDoanhThu.Name = "btn_QuanLyDoanhThu";
            this.btn_QuanLyDoanhThu.Size = new System.Drawing.Size(250, 80);
            this.btn_QuanLyDoanhThu.TabIndex = 11;
            this.btn_QuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.btn_QuanLyDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyDoanhThu.UseVisualStyleBackColor = false;
            this.btn_QuanLyDoanhThu.Click += new System.EventHandler(this.btn_QuanLyDoanhThu_Click);
            // 
            // btn_QuanLyThietbi
            // 
            this.btn_QuanLyThietbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_QuanLyThietbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyThietbi.FlatAppearance.BorderSize = 0;
            this.btn_QuanLyThietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyThietbi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLyThietbi.Location = new System.Drawing.Point(0, 512);
            this.btn_QuanLyThietbi.Name = "btn_QuanLyThietbi";
            this.btn_QuanLyThietbi.Size = new System.Drawing.Size(250, 80);
            this.btn_QuanLyThietbi.TabIndex = 7;
            this.btn_QuanLyThietbi.Text = "Quản lý thiết bị";
            this.btn_QuanLyThietbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyThietbi.UseVisualStyleBackColor = false;
            this.btn_QuanLyThietbi.Click += new System.EventHandler(this.btn_QuanLyThietbi_Click);
            // 
            // GroupQuanLyNhanVien
            // 
            this.GroupQuanLyNhanVien.Controls.Add(this.btn_LichTrucPT);
            this.GroupQuanLyNhanVien.Controls.Add(this.btn_DsNhanVien);
            this.GroupQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupQuanLyNhanVien.Location = new System.Drawing.Point(0, 410);
            this.GroupQuanLyNhanVien.Name = "GroupQuanLyNhanVien";
            this.GroupQuanLyNhanVien.Size = new System.Drawing.Size(250, 102);
            this.GroupQuanLyNhanVien.TabIndex = 10;
            // 
            // btn_LichTrucPT
            // 
            this.btn_LichTrucPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btn_LichTrucPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LichTrucPT.FlatAppearance.BorderSize = 0;
            this.btn_LichTrucPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichTrucPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichTrucPT.Location = new System.Drawing.Point(0, 50);
            this.btn_LichTrucPT.Name = "btn_LichTrucPT";
            this.btn_LichTrucPT.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_LichTrucPT.Size = new System.Drawing.Size(250, 50);
            this.btn_LichTrucPT.TabIndex = 9;
            this.btn_LichTrucPT.Text = "Lịch trực PT";
            this.btn_LichTrucPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichTrucPT.UseVisualStyleBackColor = false;
            this.btn_LichTrucPT.Click += new System.EventHandler(this.btn_LichTrucPT_Click);
            // 
            // btn_DsNhanVien
            // 
            this.btn_DsNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btn_DsNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DsNhanVien.FlatAppearance.BorderSize = 0;
            this.btn_DsNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DsNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btn_DsNhanVien.Name = "btn_DsNhanVien";
            this.btn_DsNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_DsNhanVien.Size = new System.Drawing.Size(250, 50);
            this.btn_DsNhanVien.TabIndex = 8;
            this.btn_DsNhanVien.Text = "Danh sách";
            this.btn_DsNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DsNhanVien.UseVisualStyleBackColor = false;
            this.btn_DsNhanVien.Click += new System.EventHandler(this.btn_DsNhanVien_Click);
            // 
            // btn_QuanLyNhanvien
            // 
            this.btn_QuanLyNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_QuanLyNhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyNhanvien.FlatAppearance.BorderSize = 0;
            this.btn_QuanLyNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyNhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLyNhanvien.Location = new System.Drawing.Point(0, 330);
            this.btn_QuanLyNhanvien.Name = "btn_QuanLyNhanvien";
            this.btn_QuanLyNhanvien.Size = new System.Drawing.Size(250, 80);
            this.btn_QuanLyNhanvien.TabIndex = 6;
            this.btn_QuanLyNhanvien.Text = "Quản lý nhân viên";
            this.btn_QuanLyNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyNhanvien.UseVisualStyleBackColor = false;
            this.btn_QuanLyNhanvien.Click += new System.EventHandler(this.btn_QuanLyNhanvien_Click);
            // 
            // GroupQuanLyHoiVien
            // 
            this.GroupQuanLyHoiVien.Controls.Add(this.btn_Dangky);
            this.GroupQuanLyHoiVien.Controls.Add(this.btn_Danhsach);
            this.GroupQuanLyHoiVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupQuanLyHoiVien.Location = new System.Drawing.Point(0, 180);
            this.GroupQuanLyHoiVien.Name = "GroupQuanLyHoiVien";
            this.GroupQuanLyHoiVien.Size = new System.Drawing.Size(250, 150);
            this.GroupQuanLyHoiVien.TabIndex = 5;
            this.GroupQuanLyHoiVien.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupQuanLyHoiVien_Paint);
            // 
            // btn_Dangky
            // 
            this.btn_Dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btn_Dangky.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dangky.FlatAppearance.BorderSize = 0;
            this.btn_Dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangky.Location = new System.Drawing.Point(0, 50);
            this.btn_Dangky.Name = "btn_Dangky";
            this.btn_Dangky.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Dangky.Size = new System.Drawing.Size(250, 50);
            this.btn_Dangky.TabIndex = 2;
            this.btn_Dangky.Text = "Đăng ký hội viên";
            this.btn_Dangky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dangky.UseVisualStyleBackColor = false;
            this.btn_Dangky.Click += new System.EventHandler(this.btn_Dangky_Click);
            // 
            // btn_Danhsach
            // 
            this.btn_Danhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btn_Danhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Danhsach.FlatAppearance.BorderSize = 0;
            this.btn_Danhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Danhsach.Location = new System.Drawing.Point(0, 0);
            this.btn_Danhsach.Name = "btn_Danhsach";
            this.btn_Danhsach.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Danhsach.Size = new System.Drawing.Size(250, 50);
            this.btn_Danhsach.TabIndex = 0;
            this.btn_Danhsach.Text = "Danh sách";
            this.btn_Danhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Danhsach.UseVisualStyleBackColor = false;
            this.btn_Danhsach.Click += new System.EventHandler(this.btn_Danhsach_Click);
            // 
            // btn_QuanLyHoiVien
            // 
            this.btn_QuanLyHoiVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_QuanLyHoiVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyHoiVien.FlatAppearance.BorderSize = 0;
            this.btn_QuanLyHoiVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyHoiVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyHoiVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_QuanLyHoiVien.Location = new System.Drawing.Point(0, 100);
            this.btn_QuanLyHoiVien.Name = "btn_QuanLyHoiVien";
            this.btn_QuanLyHoiVien.Size = new System.Drawing.Size(250, 80);
            this.btn_QuanLyHoiVien.TabIndex = 4;
            this.btn_QuanLyHoiVien.Text = "Quản lý hội viên";
            this.btn_QuanLyHoiVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyHoiVien.UseVisualStyleBackColor = false;
            this.btn_QuanLyHoiVien.Click += new System.EventHandler(this.btn_QuanLyHoiVien_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::Gym_management_appication.Properties.Resources.istockphoto_953455856_170667a;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 100);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Click += new System.EventHandler(this.logoPanel_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(250, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1006, 840);
            this.container.TabIndex = 6;
            // 
            // BW
            // 
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Dữ liệu đã được cập nhật";
            this.notifyIcon1.BalloonTipTitle = "Khởi chạy hoàn tất";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 840);
            this.Controls.Add(this.container);
            this.Controls.Add(this.sidePanel);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidePanel.ResumeLayout(false);
            this.GroupQuanLyDoanhThu.ResumeLayout(false);
            this.GroupQuanLyNhanVien.ResumeLayout(false);
            this.GroupQuanLyHoiVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel GroupQuanLyHoiVien;
        private System.Windows.Forms.Button btn_Danhsach;
        private System.Windows.Forms.Button btn_QuanLyHoiVien;
        private System.Windows.Forms.Button btn_QuanLyNhanvien;
        private System.Windows.Forms.Button btn_QuanLyThietbi;
        private System.Windows.Forms.Button btn_LichTrucPT;
        private System.Windows.Forms.Button btn_DsNhanVien;
        private System.Windows.Forms.Panel GroupQuanLyNhanVien;
        private System.Windows.Forms.Panel GroupQuanLyDoanhThu;
        private System.Windows.Forms.Button btn_QuanLyDoanhThu;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Button btn_Dangky;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_Phanhoi;
        private System.ComponentModel.BackgroundWorker BW;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}