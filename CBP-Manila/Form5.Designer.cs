namespace CBP_Manila
{
    partial class Form5
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.log_inBTN = new System.Windows.Forms.Button();
            this.sign_upBTN = new System.Windows.Forms.Button();
            this.passwordTXT = new System.Windows.Forms.Label();
            this.usernameTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic);
            this.username.Location = new System.Drawing.Point(648, 299);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(305, 41);
            this.username.TabIndex = 0;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(648, 372);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(305, 41);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // log_inBTN
            // 
            this.log_inBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.log_inBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_inBTN.Location = new System.Drawing.Point(611, 424);
            this.log_inBTN.Name = "log_inBTN";
            this.log_inBTN.Size = new System.Drawing.Size(329, 43);
            this.log_inBTN.TabIndex = 2;
            this.log_inBTN.Text = "Log In";
            this.log_inBTN.UseVisualStyleBackColor = false;
            this.log_inBTN.Click += new System.EventHandler(this.log_inBTN_Click);
            this.log_inBTN.MouseLeave += new System.EventHandler(this.log_inBTN_MouseLeave);
            this.log_inBTN.MouseHover += new System.EventHandler(this.log_inBTN_MouseHover);
            // 
            // sign_upBTN
            // 
            this.sign_upBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sign_upBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_upBTN.Location = new System.Drawing.Point(611, 473);
            this.sign_upBTN.Name = "sign_upBTN";
            this.sign_upBTN.Size = new System.Drawing.Size(329, 43);
            this.sign_upBTN.TabIndex = 3;
            this.sign_upBTN.Text = "Sign Up";
            this.sign_upBTN.UseVisualStyleBackColor = false;
            this.sign_upBTN.Click += new System.EventHandler(this.sign_upBTN_Click);
            this.sign_upBTN.MouseLeave += new System.EventHandler(this.sign_upBTN_MouseLeave);
            this.sign_upBTN.MouseHover += new System.EventHandler(this.sign_upBTN_MouseHover);
            // 
            // passwordTXT
            // 
            this.passwordTXT.BackColor = System.Drawing.Color.White;
            this.passwordTXT.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic);
            this.passwordTXT.Location = new System.Drawing.Point(648, 368);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(305, 41);
            this.passwordTXT.TabIndex = 5;
            this.passwordTXT.Text = "Password";
            this.passwordTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordTXT.Click += new System.EventHandler(this.passwordTXT_Click);
            // 
            // usernameTXT
            // 
            this.usernameTXT.BackColor = System.Drawing.Color.White;
            this.usernameTXT.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic);
            this.usernameTXT.Location = new System.Drawing.Point(645, 299);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(308, 41);
            this.usernameTXT.TabIndex = 6;
            this.usernameTXT.Text = "Username";
            this.usernameTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameTXT.Click += new System.EventHandler(this.usernameTXT_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CBP_Manila.Properties.Resources.Log_In;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 636);
            this.Controls.Add(this.usernameTXT);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.sign_upBTN);
            this.Controls.Add(this.log_inBTN);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Click += new System.EventHandler(this.Form5_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button log_inBTN;
        private System.Windows.Forms.Button sign_upBTN;
        private System.Windows.Forms.Label passwordTXT;
        private System.Windows.Forms.Label usernameTXT;
    }
}