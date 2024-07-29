
namespace Gym_management_appication.UI
{
    partial class Loghistory
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
            this.Logdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Logdata)).BeginInit();
            this.SuspendLayout();
            // 
            // Logdata
            // 
            this.Logdata.AllowUserToAddRows = false;
            this.Logdata.AllowUserToDeleteRows = false;
            this.Logdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Logdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Logdata.Location = new System.Drawing.Point(12, 12);
            this.Logdata.Name = "Logdata";
            this.Logdata.RowHeadersVisible = false;
            this.Logdata.RowHeadersWidth = 51;
            this.Logdata.RowTemplate.Height = 24;
            this.Logdata.Size = new System.Drawing.Size(776, 426);
            this.Logdata.TabIndex = 0;
            // 
            // Loghistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logdata);
            this.Name = "Loghistory";
            this.Text = "Loghistory";
            this.Load += new System.EventHandler(this.Loghistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Logdata;
    }
}