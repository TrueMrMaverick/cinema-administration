namespace HotelAdministation.Views
{
    partial class AddUserView
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
            this.label5 = new System.Windows.Forms.Label();
            this.roleChooser = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Роль";
            // 
            // roleChooser
            // 
            this.roleChooser.FormattingEnabled = true;
            this.roleChooser.Location = new System.Drawing.Point(12, 248);
            this.roleChooser.Name = "roleChooser";
            this.roleChooser.Size = new System.Drawing.Size(114, 21);
            this.roleChooser.TabIndex = 30;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(199, 316);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 29;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(118, 316);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(12, 209);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(262, 20);
            this.emailInput.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Почта";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(12, 168);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(262, 20);
            this.passwordInput.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пароль";
            // 
            // surNameInput
            // 
            this.surNameInput.Location = new System.Drawing.Point(12, 124);
            this.surNameInput.Name = "surNameInput";
            this.surNameInput.Size = new System.Drawing.Size(262, 20);
            this.surNameInput.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Отчество";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(12, 79);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(262, 20);
            this.firstNameInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // secondNameInput
            // 
            this.secondNameInput.Location = new System.Drawing.Point(14, 38);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(262, 20);
            this.secondNameInput.TabIndex = 17;
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Location = new System.Drawing.Point(13, 21);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(56, 13);
            this.secondNameLable.TabIndex = 16;
            this.secondNameLable.Text = "Фамилия";
            // 
            // label6
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.loginErrorLabel.Location = new System.Drawing.Point(11, 281);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(253, 13);
            this.loginErrorLabel.TabIndex = 32;
            this.loginErrorLabel.Text = "Пользователь с таким логином уже существует";
            this.loginErrorLabel.Visible = false;
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 358);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roleChooser);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNameInput);
            this.Controls.Add(this.secondNameLable);
            this.Name = "AddUserView";
            this.Text = "AddUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roleChooser;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}