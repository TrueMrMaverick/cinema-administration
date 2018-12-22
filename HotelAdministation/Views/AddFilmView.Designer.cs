namespace HotelAdministation.Views
{
    partial class AddFilmView
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
            this.label1 = new System.Windows.Forms.Label();
            this.filmName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.durationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.directorsButton = new System.Windows.Forms.Button();
            this.operatorsButton = new System.Windows.Forms.Button();
            this.actorsButton = new System.Windows.Forms.Button();
            this.genresButton = new System.Windows.Forms.Button();
            this.productionButton = new System.Windows.Forms.Button();
            this.prizesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название фильма";
            // 
            // filmName
            // 
            this.filmName.Location = new System.Drawing.Point(12, 43);
            this.filmName.Name = "filmName";
            this.filmName.Size = new System.Drawing.Size(189, 20);
            this.filmName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Продолжительность";
            // 
            // durationTimePicker
            // 
            this.durationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.durationTimePicker.Location = new System.Drawing.Point(12, 83);
            this.durationTimePicker.Name = "durationTimePicker";
            this.durationTimePicker.ShowUpDown = true;
            this.durationTimePicker.Size = new System.Drawing.Size(189, 20);
            this.durationTimePicker.TabIndex = 3;
            this.durationTimePicker.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            // 
            // rentalPrice
            // 
            this.rentalPrice.Location = new System.Drawing.Point(12, 127);
            this.rentalPrice.Name = "rentalPrice";
            this.rentalPrice.Size = new System.Drawing.Size(189, 20);
            this.rentalPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(272, 409);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Сохранить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(353, 409);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // directorsButton
            // 
            this.directorsButton.Location = new System.Drawing.Point(13, 154);
            this.directorsButton.Name = "directorsButton";
            this.directorsButton.Size = new System.Drawing.Size(188, 23);
            this.directorsButton.TabIndex = 8;
            this.directorsButton.Text = "Режисёры";
            this.directorsButton.UseVisualStyleBackColor = true;
            this.directorsButton.Click += new System.EventHandler(this.directorsButton_Click);
            // 
            // operatorsButton
            // 
            this.operatorsButton.Location = new System.Drawing.Point(13, 183);
            this.operatorsButton.Name = "operatorsButton";
            this.operatorsButton.Size = new System.Drawing.Size(188, 23);
            this.operatorsButton.TabIndex = 9;
            this.operatorsButton.Text = "Операторы";
            this.operatorsButton.UseVisualStyleBackColor = true;
            this.operatorsButton.Click += new System.EventHandler(this.operatorsButton_Click);
            // 
            // actorsButton
            // 
            this.actorsButton.Location = new System.Drawing.Point(13, 212);
            this.actorsButton.Name = "actorsButton";
            this.actorsButton.Size = new System.Drawing.Size(188, 23);
            this.actorsButton.TabIndex = 10;
            this.actorsButton.Text = "Актёры";
            this.actorsButton.UseVisualStyleBackColor = true;
            this.actorsButton.Click += new System.EventHandler(this.actorsButton_Click);
            // 
            // genresButton
            // 
            this.genresButton.Location = new System.Drawing.Point(13, 263);
            this.genresButton.Name = "genresButton";
            this.genresButton.Size = new System.Drawing.Size(188, 23);
            this.genresButton.TabIndex = 11;
            this.genresButton.Text = "Жанры";
            this.genresButton.UseVisualStyleBackColor = true;
            this.genresButton.Click += new System.EventHandler(this.genresButton_Click);
            // 
            // productionButton
            // 
            this.productionButton.Location = new System.Drawing.Point(13, 292);
            this.productionButton.Name = "productionButton";
            this.productionButton.Size = new System.Drawing.Size(188, 23);
            this.productionButton.TabIndex = 12;
            this.productionButton.Text = "Студии";
            this.productionButton.UseVisualStyleBackColor = true;
            this.productionButton.Click += new System.EventHandler(this.productionButton_Click);
            // 
            // prizesButton
            // 
            this.prizesButton.Location = new System.Drawing.Point(13, 321);
            this.prizesButton.Name = "prizesButton";
            this.prizesButton.Size = new System.Drawing.Size(188, 23);
            this.prizesButton.TabIndex = 13;
            this.prizesButton.Text = "Награды";
            this.prizesButton.UseVisualStyleBackColor = true;
            this.prizesButton.Click += new System.EventHandler(this.prizesButton_Click);
            // 
            // AddFilmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 444);
            this.Controls.Add(this.prizesButton);
            this.Controls.Add(this.productionButton);
            this.Controls.Add(this.genresButton);
            this.Controls.Add(this.actorsButton);
            this.Controls.Add(this.operatorsButton);
            this.Controls.Add(this.directorsButton);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rentalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.durationTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filmName);
            this.Controls.Add(this.label1);
            this.Name = "AddFilmView";
            this.Text = "AddFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox filmName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker durationTimePicker;
        public System.Windows.Forms.TextBox rentalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button directorsButton;
        private System.Windows.Forms.Button operatorsButton;
        private System.Windows.Forms.Button actorsButton;
        private System.Windows.Forms.Button genresButton;
        private System.Windows.Forms.Button productionButton;
        private System.Windows.Forms.Button prizesButton;
    }
}