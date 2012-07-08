namespace ObliqueStrategies.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowLast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAutoshow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshowDisabled = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow15min = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow30min = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow1h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow3h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow6h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow12h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoshow24h = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowOnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutostart = new System.Windows.Forms.ToolStripMenuItem();
            this.tssDown = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // niMain
            // 
            this.niMain.BalloonTipTitle = "Oblique Strategy";
            this.niMain.ContextMenuStrip = this.cmsMain;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Oblique Strategies";
            this.niMain.Visible = true;
            this.niMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niMain_MouseClick);
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiShowLast,
            this.toolStripSeparator2,
            this.tsmiAutoshow,
            this.tsmiShowOnStart,
            this.tsmiAutostart,
            this.tssDown,
            this.tsmiAbout,
            this.tsmiExit});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(218, 192);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(217, 22);
            this.tsmiShow.Text = "Show Strategy";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiShowLast
            // 
            this.tsmiShowLast.Name = "tsmiShowLast";
            this.tsmiShowLast.Size = new System.Drawing.Size(217, 22);
            this.tsmiShowLast.Text = "Show Last  Viewed Strategy";
            this.tsmiShowLast.Click += new System.EventHandler(this.tsmiShowLast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiAutoshow
            // 
            this.tsmiAutoshow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutoshowDisabled,
            this.tsmiAutoshow15min,
            this.tsmiAutoshow30min,
            this.tsmiAutoshow1h,
            this.tsmiAutoshow3h,
            this.tsmiAutoshow6h,
            this.tsmiAutoshow12h,
            this.tsmiAutoshow24h});
            this.tsmiAutoshow.Name = "tsmiAutoshow";
            this.tsmiAutoshow.Size = new System.Drawing.Size(217, 22);
            this.tsmiAutoshow.Text = "Autoshow Strategy after";
            // 
            // tsmiAutoshowDisabled
            // 
            this.tsmiAutoshowDisabled.Checked = true;
            this.tsmiAutoshowDisabled.CheckOnClick = true;
            this.tsmiAutoshowDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAutoshowDisabled.Name = "tsmiAutoshowDisabled";
            this.tsmiAutoshowDisabled.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshowDisabled.Tag = "0";
            this.tsmiAutoshowDisabled.Text = "Disabled";
            // 
            // tsmiAutoshow15min
            // 
            this.tsmiAutoshow15min.CheckOnClick = true;
            this.tsmiAutoshow15min.Name = "tsmiAutoshow15min";
            this.tsmiAutoshow15min.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow15min.Tag = "900000";
            this.tsmiAutoshow15min.Text = "15 min";
            // 
            // tsmiAutoshow30min
            // 
            this.tsmiAutoshow30min.CheckOnClick = true;
            this.tsmiAutoshow30min.Name = "tsmiAutoshow30min";
            this.tsmiAutoshow30min.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow30min.Tag = "1800000";
            this.tsmiAutoshow30min.Text = "30 min";
            // 
            // tsmiAutoshow1h
            // 
            this.tsmiAutoshow1h.CheckOnClick = true;
            this.tsmiAutoshow1h.Name = "tsmiAutoshow1h";
            this.tsmiAutoshow1h.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow1h.Tag = "3600000";
            this.tsmiAutoshow1h.Text = "1 h";
            // 
            // tsmiAutoshow3h
            // 
            this.tsmiAutoshow3h.CheckOnClick = true;
            this.tsmiAutoshow3h.Name = "tsmiAutoshow3h";
            this.tsmiAutoshow3h.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow3h.Tag = "10800000";
            this.tsmiAutoshow3h.Text = "3 h";
            // 
            // tsmiAutoshow6h
            // 
            this.tsmiAutoshow6h.CheckOnClick = true;
            this.tsmiAutoshow6h.Name = "tsmiAutoshow6h";
            this.tsmiAutoshow6h.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow6h.Tag = "21600000";
            this.tsmiAutoshow6h.Text = "6 h";
            // 
            // tsmiAutoshow12h
            // 
            this.tsmiAutoshow12h.CheckOnClick = true;
            this.tsmiAutoshow12h.Name = "tsmiAutoshow12h";
            this.tsmiAutoshow12h.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow12h.Tag = "43200000";
            this.tsmiAutoshow12h.Text = "12 h";
            // 
            // tsmiAutoshow24h
            // 
            this.tsmiAutoshow24h.CheckOnClick = true;
            this.tsmiAutoshow24h.Name = "tsmiAutoshow24h";
            this.tsmiAutoshow24h.Size = new System.Drawing.Size(119, 22);
            this.tsmiAutoshow24h.Tag = "86400000";
            this.tsmiAutoshow24h.Text = "24 h";
            // 
            // tsmiShowOnStart
            // 
            this.tsmiShowOnStart.Checked = true;
            this.tsmiShowOnStart.CheckOnClick = true;
            this.tsmiShowOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiShowOnStart.Name = "tsmiShowOnStart";
            this.tsmiShowOnStart.Size = new System.Drawing.Size(217, 22);
            this.tsmiShowOnStart.Text = "Show Strategy on Start";
            this.tsmiShowOnStart.Click += new System.EventHandler(this.tsmiShowOnStart_Click);
            // 
            // tsmiAutostart
            // 
            this.tsmiAutostart.CheckOnClick = true;
            this.tsmiAutostart.Name = "tsmiAutostart";
            this.tsmiAutostart.Size = new System.Drawing.Size(217, 22);
            this.tsmiAutostart.Text = "Autostart Program";
            this.tsmiAutostart.Click += new System.EventHandler(this.tsmiAutostart_Click);
            // 
            // tssDown
            // 
            this.tssDown.Name = "tssDown";
            this.tssDown.Size = new System.Drawing.Size(214, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(217, 22);
            this.tsmiAbout.Text = "About \"Oblique Stategies\"";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(217, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshowDisabled;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow15min;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow30min;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow1h;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowOnStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutostart;
        private System.Windows.Forms.ToolStripSeparator tssDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow3h;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow6h;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow12h;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoshow24h;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLast;
    }
}

