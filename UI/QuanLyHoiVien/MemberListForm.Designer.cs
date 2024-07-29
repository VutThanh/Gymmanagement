namespace Gym_management_appication.Database.QuanLyHoiVien
{
    partial class MemberListForm
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
            this.dataGridViewHoiVien = new System.Windows.Forms.DataGridView();
            this.Chọn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.cb_endDayincluded = new System.Windows.Forms.CheckBox();
            this.dateTimePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayThamGia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiVien)).BeginInit();
            this.panelNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHoiVien
            // 
            this.dataGridViewHoiVien.AllowUserToAddRows = false;
            this.dataGridViewHoiVien.AllowUserToDeleteRows = false;
            this.dataGridViewHoiVien.AllowUserToResizeRows = false;
            this.dataGridViewHoiVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHoiVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.dataGridViewHoiVien.ColumnHeadersHeight = 29;
            this.dataGridViewHoiVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chọn});
            this.dataGridViewHoiVien.Location = new System.Drawing.Point(14, 321);
            this.dataGridViewHoiVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoiVien.Name = "dataGridViewHoiVien";
            this.dataGridViewHoiVien.RowHeadersVisible = false;
            this.dataGridViewHoiVien.RowHeadersWidth = 51;
            this.dataGridViewHoiVien.RowTemplate.Height = 24;
            this.dataGridViewHoiVien.Size = new System.Drawing.Size(1269, 422);
            this.dataGridViewHoiVien.TabIndex = 3;
            this.dataGridViewHoiVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHoiVien_CellContentClick);
            // 
            // Chọn
            // 
            this.Chọn.HeaderText = "";
            this.Chọn.MinimumWidth = 6;
            this.Chọn.Name = "Chọn";
            this.Chọn.Text = "Chọn";
            this.Chọn.UseColumnTextForButtonValue = true;
            this.Chọn.Width = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(219, 251);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 39);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.panelNhanVien.Controls.Add(this.cb_endDayincluded);
            this.panelNhanVien.Controls.Add(this.dateTimePickerNgayKetThuc);
            this.panelNhanVien.Controls.Add(this.label7);
            this.panelNhanVien.Controls.Add(this.dateTimePickerNgayThamGia);
            this.panelNhanVien.Controls.Add(this.label6);
            this.panelNhanVien.Controls.Add(this.textBoxSDT);
            this.panelNhanVien.Controls.Add(this.label4);
            this.panelNhanVien.Controls.Add(this.textBoxTuoi);
            this.panelNhanVien.Controls.Add(this.label5);
            this.panelNhanVien.Controls.Add(this.radioButtonNam);
            this.panelNhanVien.Controls.Add(this.radioButtonNu);
            this.panelNhanVien.Controls.Add(this.textBoxTen);
            this.panelNhanVien.Controls.Add(this.textBoxID);
            this.panelNhanVien.Controls.Add(this.label3);
            this.panelNhanVien.Controls.Add(this.label2);
            this.panelNhanVien.Controls.Add(this.label1);
            this.panelNhanVien.Controls.Add(this.btnReset);
            this.panelNhanVien.Controls.Add(this.btnDelete);
            this.panelNhanVien.Controls.Add(this.btnUpdate);
            this.panelNhanVien.Controls.Add(this.btnInsert);
            this.panelNhanVien.Location = new System.Drawing.Point(3, 9);
            this.panelNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(1293, 305);
            this.panelNhanVien.TabIndex = 4;
            // 
            // cb_endDayincluded
            // 
            this.cb_endDayincluded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_endDayincluded.AutoSize = true;
            this.cb_endDayincluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_endDayincluded.Location = new System.Drawing.Point(899, 178);
            this.cb_endDayincluded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_endDayincluded.Name = "cb_endDayincluded";
            this.cb_endDayincluded.Size = new System.Drawing.Size(125, 24);
            this.cb_endDayincluded.TabIndex = 39;
            this.cb_endDayincluded.Text = "đã kết thúc";
            this.cb_endDayincluded.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgayKetThuc
            // 
            this.dateTimePickerNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayKetThuc.Location = new System.Drawing.Point(899, 122);
            this.dateTimePickerNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayKetThuc.Name = "dateTimePickerNgayKetThuc";
            this.dateTimePickerNgayKetThuc.Size = new System.Drawing.Size(370, 26);
            this.dateTimePickerNgayKetThuc.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(766, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày kết thúc";
            // 
            // dateTimePickerNgayThamGia
            // 
            this.dateTimePickerNgayThamGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerNgayThamGia.Location = new System.Drawing.Point(899, 78);
            this.dateTimePickerNgayThamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerNgayThamGia.Name = "dateTimePickerNgayThamGia";
            this.dateTimePickerNgayThamGia.Size = new System.Drawing.Size(370, 26);
            this.dateTimePickerNgayThamGia.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày tham gia";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSDT.Location = new System.Drawing.Point(899, 26);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(370, 26);
            this.textBoxSDT.TabIndex = 32;
            this.textBoxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSDT_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(766, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số điện thoại";
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.Location = new System.Drawing.Point(141, 121);
            this.textBoxTuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(370, 26);
            this.textBoxTuoi.TabIndex = 30;
            this.textBoxTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTuoi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tuổi";
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(141, 178);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(67, 24);
            this.radioButtonNam.TabIndex = 28;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            this.radioButtonNam.CheckedChanged += new System.EventHandler(this.RadioButtonNam_CheckedChanged);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(255, 178);
            this.radioButtonNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(54, 24);
            this.radioButtonNu.TabIndex = 27;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.CheckedChanged += new System.EventHandler(this.RadioButtonNu_CheckedChanged);
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(141, 68);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(370, 26);
            this.textBoxTen.TabIndex = 25;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(141, 22);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(370, 26);
            this.textBoxID.TabIndex = 24;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Họ tên";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(633, 251);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(495, 251);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(357, 251);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1296, 754);
            this.Controls.Add(this.dataGridViewHoiVien);
            this.Controls.Add(this.panelNhanVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MemberListForm";
            this.Text = "MemberListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiVien)).EndInit();
            this.panelNhanVien.ResumeLayout(false);
            this.panelNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHoiVien;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThamGia;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Chọn;
        private System.Windows.Forms.CheckBox cb_endDayincluded;
    }
}