
namespace Gym_management_appication.UI
{
    partial class Login
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
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_DB = new System.Windows.Forms.TextBox();
            this.chB_saveUser = new System.Windows.Forms.CheckBox();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(71, 104);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(260, 22);
            this.txt_userName.TabIndex = 0;
            this.txt_userName.Text = "User name";
            this.txt_userName.Enter += new System.EventHandler(this.txt_userName_Enter);
            this.txt_userName.Leave += new System.EventHandler(this.txt_userName_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(71, 132);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(260, 22);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Password";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(39)))), ((int)(((byte)(18)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Login.Location = new System.Drawing.Point(146, 221);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(103, 36);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_DB
            // 
            this.txt_DB.Location = new System.Drawing.Point(71, 160);
            this.txt_DB.Name = "txt_DB";
            this.txt_DB.Size = new System.Drawing.Size(260, 22);
            this.txt_DB.TabIndex = 3;
            this.txt_DB.Text = "Database Name";
            this.txt_DB.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txt_DB.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // chB_saveUser
            // 
            this.chB_saveUser.AutoSize = true;
            this.chB_saveUser.Location = new System.Drawing.Point(71, 188);
            this.chB_saveUser.Name = "chB_saveUser";
            this.chB_saveUser.Size = new System.Drawing.Size(152, 21);
            this.chB_saveUser.TabIndex = 4;
            this.chB_saveUser.Text = "Nhớ tên đăng nhập";
            this.chB_saveUser.UseVisualStyleBackColor = true;
            this.chB_saveUser.CheckedChanged += new System.EventHandler(this.chB_saveUser_CheckedChanged);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Quit.Location = new System.Drawing.Point(325, 232);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(65, 36);
            this.btn_Quit.TabIndex = 5;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(402, 280);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.chB_saveUser);
            this.Controls.Add(this.txt_DB);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_userName);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_DB;
        private System.Windows.Forms.CheckBox chB_saveUser;
        private System.Windows.Forms.Button btn_Quit;
    }
}