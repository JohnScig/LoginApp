namespace LoginApp
{
    partial class LoginWindowView
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
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Pswd = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(144, 163);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(197, 20);
            this.tb_Username.TabIndex = 0;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(144, 144);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Pswd
            // 
            this.lbl_Pswd.AutoSize = true;
            this.lbl_Pswd.Location = new System.Drawing.Point(144, 211);
            this.lbl_Pswd.Name = "lbl_Pswd";
            this.lbl_Pswd.Size = new System.Drawing.Size(53, 13);
            this.lbl_Pswd.TabIndex = 2;
            this.lbl_Pswd.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(144, 227);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(197, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Location = new System.Drawing.Point(141, 88);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(200, 40);
            this.lbl_Error.TabIndex = 4;
            this.lbl_Error.Text = "Please contact your system administration";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Error.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(266, 284);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 363);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Pswd);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tb_Username);
            this.Name = "LoginWindowView";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Pswd;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_login;
    }
}

