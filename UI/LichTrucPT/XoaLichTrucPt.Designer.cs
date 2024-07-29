namespace Gym_management_appication.UI.LichTrucPT
{
    partial class XoaLichTrucPT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNgayTruc = new System.Windows.Forms.ComboBox();
            this.comboBoxBuoiTruc = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxHoTen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(15)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên PT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(15)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày trực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(15)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buổi trực";
            // 
            // comboBoxNgayTruc
            // 
            this.comboBoxNgayTruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.comboBoxNgayTruc.FormattingEnabled = true;
            this.comboBoxNgayTruc.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.comboBoxNgayTruc.Location = new System.Drawing.Point(102, 148);
            this.comboBoxNgayTruc.Name = "comboBoxNgayTruc";
            this.comboBoxNgayTruc.Size = new System.Drawing.Size(156, 24);
            this.comboBoxNgayTruc.TabIndex = 6;
            // 
            // comboBoxBuoiTruc
            // 
            this.comboBoxBuoiTruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.comboBoxBuoiTruc.FormattingEnabled = true;
            this.comboBoxBuoiTruc.Items.AddRange(new object[] {
            "Buổi sáng",
            "Buổi chiều",
            "Buổi tối"});
            this.comboBoxBuoiTruc.Location = new System.Drawing.Point(102, 205);
            this.comboBoxBuoiTruc.Name = "comboBoxBuoiTruc";
            this.comboBoxBuoiTruc.Size = new System.Drawing.Size(156, 24);
            this.comboBoxBuoiTruc.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.AutoSize = true;
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(15)))), ((int)(((byte)(1)))));
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOk.Location = new System.Drawing.Point(154, 323);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 37);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // comboBoxHoTen
            // 
            this.comboBoxHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.comboBoxHoTen.FormattingEnabled = true;
            this.comboBoxHoTen.Location = new System.Drawing.Point(102, 81);
            this.comboBoxHoTen.Name = "comboBoxHoTen";
            this.comboBoxHoTen.Size = new System.Drawing.Size(260, 24);
            this.comboBoxHoTen.TabIndex = 10;
            // 
            // XoaLichTrucPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 407);
            this.Controls.Add(this.comboBoxHoTen);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxBuoiTruc);
            this.Controls.Add(this.comboBoxNgayTruc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "XoaLichTrucPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemLichTrucPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNgayTruc;
        private System.Windows.Forms.ComboBox comboBoxBuoiTruc;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxHoTen;
    }
}