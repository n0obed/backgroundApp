namespace ProcessesFromsCsharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProcessName = new System.Windows.Forms.ColumnHeader();
            this.RunTime = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Memory = new System.Windows.Forms.ColumnHeader();
            this.PID = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csgoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BannerlordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.RunTime,
            this.Status,
            this.Memory,
            this.PID});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Process Name";
            this.ProcessName.Width = 100;
            // 
            // RunTime
            // 
            this.RunTime.Text = "Run Time";
            this.RunTime.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // Memory
            // 
            this.Memory.Text = "Memory";
            this.Memory.Width = 100;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.chromeToolStripMenuItem,
            this.csgoToolStripMenuItem,
            this.CitiesToolStripMenuItem,
            this.BannerlordToolStripMenuItem,
            this.steamToolStripMenuItem,
            this.teamsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 200);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.quitToolStripMenuItem.Text = "Quit App";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.Visible = false;
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click_1);
            // 
            // csgoToolStripMenuItem
            // 
            this.csgoToolStripMenuItem.Name = "csgoToolStripMenuItem";
            this.csgoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.csgoToolStripMenuItem.Text = "csgo";
            this.csgoToolStripMenuItem.Visible = false;
            this.csgoToolStripMenuItem.Click += new System.EventHandler(this.csgoToolStripMenuItem_Click);
            // 
            // CitiesToolStripMenuItem
            // 
            this.CitiesToolStripMenuItem.Name = "CitiesToolStripMenuItem";
            this.CitiesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.CitiesToolStripMenuItem.Text = "Cities";
            this.CitiesToolStripMenuItem.Visible = false;
            this.CitiesToolStripMenuItem.Click += new System.EventHandler(this.CitiesToolStripMenuItem_Click);
            // 
            // BannerlordToolStripMenuItem
            // 
            this.BannerlordToolStripMenuItem.Name = "BannerlordToolStripMenuItem";
            this.BannerlordToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.BannerlordToolStripMenuItem.Text = "Bannerlord";
            this.BannerlordToolStripMenuItem.Visible = false;
            this.BannerlordToolStripMenuItem.Click += new System.EventHandler(this.BannerlordToolStripMenuItem_Click);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.steamToolStripMenuItem.Text = "steam";
            this.steamToolStripMenuItem.Visible = false;
            this.steamToolStripMenuItem.Click += new System.EventHandler(this.steamToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Textsa";
            this.notifyIcon1.BalloonTipTitle = "Titlea";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Right Click To Kill Processes";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Visible = false;
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader ProcessName;
        private ColumnHeader PID;
        private ColumnHeader Status;
        private ColumnHeader Memory;
        private ColumnHeader RunTime;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem chromeToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem csgoToolStripMenuItem;
        private ToolStripMenuItem CitiesToolStripMenuItem;
        private ToolStripMenuItem BannerlordToolStripMenuItem;
        private ToolStripMenuItem steamToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem teamsToolStripMenuItem;
    }
}