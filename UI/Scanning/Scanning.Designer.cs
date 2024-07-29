
namespace Gym_management_appication.UI
{
    partial class Scanning
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbURLDroidCam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Alias = new System.Windows.Forms.TextBox();
            this.txt_noti = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.picCam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(132, 62);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(358, 22);
            this.txt_Name.TabIndex = 42;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(132, 27);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(159, 22);
            this.txt_ID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ tên";
            // 
            // currentTime
            // 
            this.currentTime.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.currentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currentTime.Location = new System.Drawing.Point(132, 95);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(205, 22);
            this.currentTime.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(558, 218);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 38);
            this.btnConnect.TabIndex = 48;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbURLDroidCam
            // 
            this.tbURLDroidCam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbURLDroidCam.Location = new System.Drawing.Point(120, 227);
            this.tbURLDroidCam.Margin = new System.Windows.Forms.Padding(4);
            this.tbURLDroidCam.Name = "tbURLDroidCam";
            this.tbURLDroidCam.Size = new System.Drawing.Size(430, 22);
            this.tbURLDroidCam.TabIndex = 47;
            this.tbURLDroidCam.Text = "http://192.168.110.219:4747/video";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "URL: ";
            // 
            // txt_Alias
            // 
            this.txt_Alias.Location = new System.Drawing.Point(331, 27);
            this.txt_Alias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Alias.Name = "txt_Alias";
            this.txt_Alias.Size = new System.Drawing.Size(159, 22);
            this.txt_Alias.TabIndex = 49;
            // 
            // txt_noti
            // 
            this.txt_noti.AutoSize = true;
            this.txt_noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noti.Location = new System.Drawing.Point(24, 166);
            this.txt_noti.Name = "txt_noti";
            this.txt_noti.Size = new System.Drawing.Size(92, 17);
            this.txt_noti.TabIndex = 50;
            this.txt_noti.Text = "notification!";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ngày hết hạn ";
            this.label4.Visible = false;
            // 
            // expireDate
            // 
            this.expireDate.CustomFormat = "dd/MM/yyyy";
            this.expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDate.Location = new System.Drawing.Point(469, 95);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(127, 22);
            this.expireDate.TabIndex = 52;
            this.expireDate.Visible = false;
            // 
            // picCam
            // 
            this.picCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Location = new System.Drawing.Point(13, 266);
            this.picCam.Margin = new System.Windows.Forms.Padding(4);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(707, 405);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam.TabIndex = 45;
            this.picCam.TabStop = false;
            // 
            // Scanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(733, 684);
            this.Controls.Add(this.expireDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_noti);
            this.Controls.Add(this.txt_Alias);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbURLDroidCam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Scanning";
            this.Text = "Scanning";
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker currentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbURLDroidCam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.TextBox txt_Alias;
        private System.Windows.Forms.Label txt_noti;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker expireDate;
    }
}