
namespace Gym_management_appication.UI
{
    partial class Attendance
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
            this.dtg_attendanceList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTime = new System.Windows.Forms.DateTimePicker();
            this.toTime = new System.Windows.Forms.DateTimePicker();
            this.btn_searchtimespan = new System.Windows.Forms.Button();
            this.btn_searchkeyw = new System.Windows.Forms.Button();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_attendanceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_attendanceList
            // 
            this.dtg_attendanceList.AllowUserToResizeRows = false;
            this.dtg_attendanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_attendanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_attendanceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.dtg_attendanceList.ColumnHeadersHeight = 29;
            this.dtg_attendanceList.Location = new System.Drawing.Point(12, 141);
            this.dtg_attendanceList.Name = "dtg_attendanceList";
            this.dtg_attendanceList.RowHeadersVisible = false;
            this.dtg_attendanceList.RowHeadersWidth = 51;
            this.dtg_attendanceList.RowTemplate.Height = 24;
            this.dtg_attendanceList.Size = new System.Drawing.Size(776, 297);
            this.dtg_attendanceList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            // 
            // fromTime
            // 
            this.fromTime.CustomFormat = "dd/MM/yyyy - hh:mm:ss tt";
            this.fromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromTime.Location = new System.Drawing.Point(73, 20);
            this.fromTime.Name = "fromTime";
            this.fromTime.Size = new System.Drawing.Size(221, 22);
            this.fromTime.TabIndex = 44;
            // 
            // toTime
            // 
            this.toTime.CustomFormat = "dd/MM/yyyy - hh:mm:ss tt";
            this.toTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toTime.Location = new System.Drawing.Point(356, 20);
            this.toTime.Name = "toTime";
            this.toTime.Size = new System.Drawing.Size(221, 22);
            this.toTime.TabIndex = 45;
            // 
            // btn_searchtimespan
            // 
            this.btn_searchtimespan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_searchtimespan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchtimespan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchtimespan.Location = new System.Drawing.Point(604, 16);
            this.btn_searchtimespan.Name = "btn_searchtimespan";
            this.btn_searchtimespan.Size = new System.Drawing.Size(184, 32);
            this.btn_searchtimespan.TabIndex = 46;
            this.btn_searchtimespan.Text = "Search time span";
            this.btn_searchtimespan.UseVisualStyleBackColor = false;
            this.btn_searchtimespan.Click += new System.EventHandler(this.btn_searchtimespan_Click);
            // 
            // btn_searchkeyw
            // 
            this.btn_searchkeyw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_searchkeyw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchkeyw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchkeyw.Location = new System.Drawing.Point(356, 59);
            this.btn_searchkeyw.Name = "btn_searchkeyw";
            this.btn_searchkeyw.Size = new System.Drawing.Size(162, 32);
            this.btn_searchkeyw.TabIndex = 47;
            this.btn_searchkeyw.Text = "Search keyword";
            this.btn_searchkeyw.UseVisualStyleBackColor = false;
            this.btn_searchkeyw.Click += new System.EventHandler(this.btn_searchkeyw_Click);
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(13, 65);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(315, 22);
            this.txt_keyword.TabIndex = 48;
            this.txt_keyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_keyword_KeyDown);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_keyword);
            this.Controls.Add(this.btn_searchkeyw);
            this.Controls.Add(this.btn_searchtimespan);
            this.Controls.Add(this.toTime);
            this.Controls.Add(this.fromTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_attendanceList);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_attendanceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_attendanceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromTime;
        private System.Windows.Forms.DateTimePicker toTime;
        private System.Windows.Forms.Button btn_searchtimespan;
        private System.Windows.Forms.Button btn_searchkeyw;
        private System.Windows.Forms.TextBox txt_keyword;
    }
}