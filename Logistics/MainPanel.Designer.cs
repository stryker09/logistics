namespace Logistics
{
    partial class MainPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logsDateTBox = new System.Windows.Forms.TextBox();
            this.logPull = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerServerCBox = new System.Windows.Forms.ComboBox();
            this.customerServerLbl = new System.Windows.Forms.Label();
            this.logSetCBox = new System.Windows.Forms.ComboBox();
            this.logSetLbl = new System.Windows.Forms.Label();
            this.localLogDirLbl = new System.Windows.Forms.Label();
            this.localLogDirTBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logsDateTBox);
            this.panel1.Controls.Add(this.logPull);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logsDatePicker);
            this.panel1.Controls.Add(this.customerServerCBox);
            this.panel1.Controls.Add(this.customerServerLbl);
            this.panel1.Controls.Add(this.logSetCBox);
            this.panel1.Controls.Add(this.logSetLbl);
            this.panel1.Controls.Add(this.localLogDirLbl);
            this.panel1.Controls.Add(this.localLogDirTBox);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 113);
            this.panel1.TabIndex = 0;
            // 
            // logsDateTBox
            // 
            this.logsDateTBox.Location = new System.Drawing.Point(414, 55);
            this.logsDateTBox.Name = "logsDateTBox";
            this.logsDateTBox.Size = new System.Drawing.Size(162, 20);
            this.logsDateTBox.TabIndex = 3;
            // 
            // logPull
            // 
            this.logPull.Location = new System.Drawing.Point(670, 33);
            this.logPull.Name = "logPull";
            this.logPull.Size = new System.Drawing.Size(119, 40);
            this.logPull.TabIndex = 10;
            this.logPull.Text = "Pull";
            this.logPull.UseVisualStyleBackColor = true;
            this.logPull.Click += new System.EventHandler(this.logPull_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Logs Date:";
            // 
            // logsDatePicker
            // 
            this.logsDatePicker.Location = new System.Drawing.Point(414, 90);
            this.logsDatePicker.Name = "logsDatePicker";
            this.logsDatePicker.Size = new System.Drawing.Size(200, 20);
            this.logsDatePicker.TabIndex = 8;
            this.logsDatePicker.ValueChanged += new System.EventHandler(this.logsDatePicker_ValueChanged);
            // 
            // customerServerCBox
            // 
            this.customerServerCBox.FormattingEnabled = true;
            this.customerServerCBox.Items.AddRange(new object[] {
            "40_MY_JOHN_2012"});
            this.customerServerCBox.Location = new System.Drawing.Point(414, 19);
            this.customerServerCBox.Name = "customerServerCBox";
            this.customerServerCBox.Size = new System.Drawing.Size(162, 21);
            this.customerServerCBox.TabIndex = 7;
            // 
            // customerServerLbl
            // 
            this.customerServerLbl.AutoSize = true;
            this.customerServerLbl.Location = new System.Drawing.Point(320, 22);
            this.customerServerLbl.Name = "customerServerLbl";
            this.customerServerLbl.Size = new System.Drawing.Size(88, 13);
            this.customerServerLbl.TabIndex = 6;
            this.customerServerLbl.Text = "Customer Server:";
            // 
            // logSetCBox
            // 
            this.logSetCBox.FormattingEnabled = true;
            this.logSetCBox.Items.AddRange(new object[] {
            "VoIP - TSServer, SIPEngine, IP, Notifier",
            "Dialer - Dialer, DialerStatRepeater, Notifier",
            "Client - SessionManager, ClientServices, Notifier",
            "Server - WelSwitchover, AdminServer, ClientServices, Notifier, SwitchoverFileMon," +
                " TS, DS",
            "Data - All StatServers, TransactionServer, Notifier, Tracker, IP, DataManager",
            "ecorder - Recorder, TransactionServer",
            "Postal - PostOffice, Notifier, IP",
            "Custom Logs"});
            this.logSetCBox.Location = new System.Drawing.Point(122, 52);
            this.logSetCBox.Name = "logSetCBox";
            this.logSetCBox.Size = new System.Drawing.Size(162, 21);
            this.logSetCBox.TabIndex = 5;
            // 
            // logSetLbl
            // 
            this.logSetLbl.AutoSize = true;
            this.logSetLbl.Location = new System.Drawing.Point(14, 55);
            this.logSetLbl.Name = "logSetLbl";
            this.logSetLbl.Size = new System.Drawing.Size(92, 13);
            this.logSetLbl.TabIndex = 4;
            this.logSetLbl.Text = "Log Set to gather:";
            // 
            // localLogDirLbl
            // 
            this.localLogDirLbl.AutoSize = true;
            this.localLogDirLbl.Location = new System.Drawing.Point(14, 22);
            this.localLogDirLbl.Name = "localLogDirLbl";
            this.localLogDirLbl.Size = new System.Drawing.Size(102, 13);
            this.localLogDirLbl.TabIndex = 3;
            this.localLogDirLbl.Text = "Local Log Directory:";
            // 
            // localLogDirTBox
            // 
            this.localLogDirTBox.Location = new System.Drawing.Point(122, 19);
            this.localLogDirTBox.Name = "localLogDirTBox";
            this.localLogDirTBox.Size = new System.Drawing.Size(162, 20);
            this.localLogDirTBox.TabIndex = 2;
            this.localLogDirTBox.TextChanged += new System.EventHandler(this.localLogDirTBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBarFile
            // 
            this.menuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.Size = new System.Drawing.Size(37, 20);
            this.menuBarFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPanel";
            this.Text = "Logistics 0.1 Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBarFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox logSetCBox;
        private System.Windows.Forms.Label logSetLbl;
        private System.Windows.Forms.Label localLogDirLbl;
        private System.Windows.Forms.TextBox localLogDirTBox;
        private System.Windows.Forms.Label customerServerLbl;
        private System.Windows.Forms.ComboBox customerServerCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker logsDatePicker;
        private System.Windows.Forms.Button logPull;
        private System.Windows.Forms.TextBox logsDateTBox;

    }
}

