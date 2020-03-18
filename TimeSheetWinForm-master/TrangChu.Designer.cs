namespace TimeSheetWinForm
{
    partial class TrangChu
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
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTimeSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetStaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(805, 453);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 30);
            this.button9.TabIndex = 8;
            this.button9.Text = "LogOut";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào người trái đất";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.manageProjectToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.manageTaskToolStripMenuItem,
            this.timesheetToolStripMenuItem,
            this.myTimeSheetToolStripMenuItem,
            this.configToolStripMenuItem,
            this.timesheetStaticToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // manageProjectToolStripMenuItem
            // 
            this.manageProjectToolStripMenuItem.Name = "manageProjectToolStripMenuItem";
            this.manageProjectToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.manageProjectToolStripMenuItem.Text = "Manage Project";
            this.manageProjectToolStripMenuItem.Click += new System.EventHandler(this.manageProjectToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // manageTaskToolStripMenuItem
            // 
            this.manageTaskToolStripMenuItem.Name = "manageTaskToolStripMenuItem";
            this.manageTaskToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.manageTaskToolStripMenuItem.Text = "Manage Task";
            this.manageTaskToolStripMenuItem.Click += new System.EventHandler(this.manageTaskToolStripMenuItem_Click);
            // 
            // timesheetToolStripMenuItem
            // 
            this.timesheetToolStripMenuItem.Name = "timesheetToolStripMenuItem";
            this.timesheetToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.timesheetToolStripMenuItem.Text = "Timesheet";
            this.timesheetToolStripMenuItem.Click += new System.EventHandler(this.timesheetToolStripMenuItem_Click);
            // 
            // myTimeSheetToolStripMenuItem
            // 
            this.myTimeSheetToolStripMenuItem.Name = "myTimeSheetToolStripMenuItem";
            this.myTimeSheetToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.myTimeSheetToolStripMenuItem.Text = "My Time Sheet";
            this.myTimeSheetToolStripMenuItem.Click += new System.EventHandler(this.myTimeSheetToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // timesheetStaticToolStripMenuItem
            // 
            this.timesheetStaticToolStripMenuItem.Name = "timesheetStaticToolStripMenuItem";
            this.timesheetStaticToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.timesheetStaticToolStripMenuItem.Text = "TimesheetStatic";
            this.timesheetStaticToolStripMenuItem.Click += new System.EventHandler(this.timesheetStaticToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 410);
            this.panel1.TabIndex = 11;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrangChu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTimeSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetStaticToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}