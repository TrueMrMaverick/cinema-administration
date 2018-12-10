namespace HotelAdministation.Views
{
    partial class LoginView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(27, 97);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(203, 20);
            this.PasswordText.TabIndex = 10;
            this.PasswordText.Text = "Пароль";
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(27, 45);
            this.LoginText.Name = "LoginText";
            this.LoginText.ReadOnly = true;
            this.LoginText.Size = new System.Drawing.Size(203, 20);
            this.LoginText.TabIndex = 9;
            this.LoginText.Text = "Логин";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(155, 149);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(27, 123);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(203, 20);
            this.password.TabIndex = 7;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(27, 71);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 20);
            this.login.TabIndex = 6;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.BackColor = System.Drawing.Color.IndianRed;
            this.errorMsg.Location = new System.Drawing.Point(37, 29);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(175, 13);
            this.errorMsg.TabIndex = 12;
            this.errorMsg.Text = "Неправильный логин или пароль";
            this.errorMsg.Visible = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(259, 197);
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label errorMsg;
    }
}
