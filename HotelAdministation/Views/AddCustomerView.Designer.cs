namespace HotelAdministation.Views
{
    partial class AddCustomerView
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
            this.secondNameLable = new System.Windows.Forms.Label();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.roomsChooser = new System.Windows.Forms.ComboBox();
            this.roomsChooserLable = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passportIdInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.townInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.roomTypeChooser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Location = new System.Drawing.Point(12, 37);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(56, 13);
            this.secondNameLable.TabIndex = 0;
            this.secondNameLable.Text = "Фамилия";
            // 
            // secondNameInput
            // 
            this.secondNameInput.Location = new System.Drawing.Point(13, 54);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(262, 20);
            this.secondNameInput.TabIndex = 1;
            // 
            // roomsChooser
            // 
            this.roomsChooser.FormattingEnabled = true;
            this.roomsChooser.Location = new System.Drawing.Point(161, 264);
            this.roomsChooser.Name = "roomsChooser";
            this.roomsChooser.Size = new System.Drawing.Size(111, 21);
            this.roomsChooser.TabIndex = 2;
            // 
            // roomsChooserLable
            // 
            this.roomsChooserLable.AutoSize = true;
            this.roomsChooserLable.Location = new System.Drawing.Point(160, 248);
            this.roomsChooserLable.Name = "roomsChooserLable";
            this.roomsChooserLable.Size = new System.Drawing.Size(112, 13);
            this.roomsChooserLable.TabIndex = 3;
            this.roomsChooserLable.Text = "Свободные комнаты";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(11, 95);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(262, 20);
            this.firstNameInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // surNameInput
            // 
            this.surNameInput.Location = new System.Drawing.Point(11, 140);
            this.surNameInput.Name = "surNameInput";
            this.surNameInput.Size = new System.Drawing.Size(262, 20);
            this.surNameInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отчество";
            // 
            // passportIdInput
            // 
            this.passportIdInput.Location = new System.Drawing.Point(11, 184);
            this.passportIdInput.Name = "passportIdInput";
            this.passportIdInput.Size = new System.Drawing.Size(262, 20);
            this.passportIdInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер паспорта";
            // 
            // townInput
            // 
            this.townInput.Location = new System.Drawing.Point(11, 225);
            this.townInput.Name = "townInput";
            this.townInput.Size = new System.Drawing.Size(262, 20);
            this.townInput.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Город";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(117, 332);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(198, 332);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тип комнаты";
            // 
            // roomTypeChooser
            // 
            this.roomTypeChooser.FormattingEnabled = true;
            this.roomTypeChooser.Location = new System.Drawing.Point(11, 264);
            this.roomTypeChooser.Name = "roomTypeChooser";
            this.roomTypeChooser.Size = new System.Drawing.Size(144, 21);
            this.roomTypeChooser.TabIndex = 14;
            this.roomTypeChooser.SelectedIndexChanged += new System.EventHandler(this.roomTypeChooser_SelectedIndexChanged);
            // 
            // AddCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomTypeChooser);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.townInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passportIdInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomsChooserLable);
            this.Controls.Add(this.roomsChooser);
            this.Controls.Add(this.secondNameInput);
            this.Controls.Add(this.secondNameLable);
            this.Name = "AddCustomerView";
            this.Text = "AddCustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.ComboBox roomsChooser;
        private System.Windows.Forms.Label roomsChooserLable;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passportIdInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox townInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roomTypeChooser;
    }
}