namespace HotelAdministation.Views
{
    partial class MainView
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSystemUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filmListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.cinemaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSystemUserToolStripMenuItem,
            this.filmListToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.administrationToolStripMenuItem.Text = "Администрирование";
            // 
            // addSystemUserToolStripMenuItem
            // 
            this.addSystemUserToolStripMenuItem.Name = "addSystemUserToolStripMenuItem";
            this.addSystemUserToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.addSystemUserToolStripMenuItem.Text = "Добавить пользователя системы";
            this.addSystemUserToolStripMenuItem.Click += new System.EventHandler(this.addSystemUserToolStripMenuItem_Click);
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemaListToolStripMenuItem});
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cinemaToolStripMenuItem.Text = "Кинотеатры";
            // 
            // cinemaListToolStripMenuItem
            // 
            this.cinemaListToolStripMenuItem.Name = "cinemaListToolStripMenuItem";
            this.cinemaListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cinemaListToolStripMenuItem.Text = "Список кинотеатров";
            this.cinemaListToolStripMenuItem.Click += new System.EventHandler(this.cinemaListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.exitToolStripMenuItem.Text = "Выход из системы";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // baseLayout
            // 
            this.baseLayout.ColumnCount = 1;
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.875F));
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.125F));
            this.baseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayout.Location = new System.Drawing.Point(0, 24);
            this.baseLayout.Margin = new System.Windows.Forms.Padding(3, 27, 3, 3);
            this.baseLayout.Name = "baseLayout";
            this.baseLayout.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.baseLayout.RowCount = 1;
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.42077F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.57924F));
            this.baseLayout.Size = new System.Drawing.Size(800, 426);
            this.baseLayout.TabIndex = 1;
            // 
            // filmListToolStripMenuItem
            // 
            this.filmListToolStripMenuItem.Name = "filmListToolStripMenuItem";
            this.filmListToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.filmListToolStripMenuItem.Text = "Список фильмов";
            this.filmListToolStripMenuItem.Click += new System.EventHandler(this.filmListToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseLayout);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainView";
            this.Text = "MainForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel baseLayout;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addSystemUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmListToolStripMenuItem;
    }
}