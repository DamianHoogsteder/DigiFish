namespace DigiFish_application
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
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txtbox_inlog_password = new System.Windows.Forms.TextBox();
            this.txtbox_inlog_username = new System.Windows.Forms.TextBox();
            this.btn_login_loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Location = new System.Drawing.Point(12, 13);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(87, 13);
            this.lbl_login_username.TabIndex = 0;
            this.lbl_login_username.Text = "Gebruikersnaam:";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Location = new System.Drawing.Point(12, 61);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(71, 13);
            this.lbl_login_password.TabIndex = 1;
            this.lbl_login_password.Text = "Wachtwoord:";
            // 
            // txtbox_inlog_password
            // 
            this.txtbox_inlog_password.Location = new System.Drawing.Point(105, 61);
            this.txtbox_inlog_password.Name = "txtbox_inlog_password";
            this.txtbox_inlog_password.Size = new System.Drawing.Size(100, 20);
            this.txtbox_inlog_password.TabIndex = 2;
            // 
            // txtbox_inlog_username
            // 
            this.txtbox_inlog_username.Location = new System.Drawing.Point(105, 13);
            this.txtbox_inlog_username.Name = "txtbox_inlog_username";
            this.txtbox_inlog_username.Size = new System.Drawing.Size(100, 20);
            this.txtbox_inlog_username.TabIndex = 3;
            // 
            // btn_login_loginButton
            // 
            this.btn_login_loginButton.Location = new System.Drawing.Point(77, 105);
            this.btn_login_loginButton.Name = "btn_login_loginButton";
            this.btn_login_loginButton.Size = new System.Drawing.Size(75, 23);
            this.btn_login_loginButton.TabIndex = 4;
            this.btn_login_loginButton.Text = "inloggen";
            this.btn_login_loginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(228, 148);
            this.Controls.Add(this.btn_login_loginButton);
            this.Controls.Add(this.txtbox_inlog_username);
            this.Controls.Add(this.txtbox_inlog_password);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txtbox_inlog_password;
        private System.Windows.Forms.TextBox txtbox_inlog_username;
        private System.Windows.Forms.Button btn_login_loginButton;
    }
}