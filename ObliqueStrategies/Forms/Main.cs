using System;
using System.Windows.Forms;
using ObliqueStrategies.Classes;

namespace ObliqueStrategies.Forms
{
    public partial class FrmMain : Form
    {
        private const int BALLOON_TOOLTIP_TIMEOUT = 18000;
        private readonly Timer _timer;
        private string _lastStrategy = null;

        private void ShowNewStrategy()
        {
            _lastStrategy = StrategiesDecks.GetStrategy();
            niMain.BalloonTipText = _lastStrategy;
            niMain.ShowBalloonTip(BALLOON_TOOLTIP_TIMEOUT);
        }

        private void ShowLastStrategy()
        {
            if (_lastStrategy!=null)
                niMain.ShowBalloonTip(BALLOON_TOOLTIP_TIMEOUT);
        }

        public FrmMain()
        {
            InitializeComponent();

            _timer = new Timer();
            _timer.Tick += timer_Tick;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            niMain.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            bool? result=false;

            //check app.config
            result = ConfigurationHelper.TryToCreateDefault();
            //can't create app.config
            if (result==null)
            {
                MessageBox.Show(this, 
                    "Program can't create configuration file in application directory and now will exit",
                    "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //app.config was created
            else if (result==true)
                Application.Restart();
            //app.config already exists

            //read autoshow parameter
            int iAutoShow=0;
            ConfigurationHelper.ReadValue("autoshow", out iAutoShow);
            //add handlers to time items
            foreach (ToolStripMenuItem tsmiChild in tsmiAutoshow.DropDownItems)
                tsmiChild.Click += tsmiAutoshow_Click;
            tsmiAutoshowDisabled.Checked = true;
            //apply autoshow parameter to item
            foreach (ToolStripMenuItem tsmiChild in tsmiAutoshow.DropDownItems)
                if (Convert.ToInt32(tsmiChild.Tag) == iAutoShow)
                {
                    tsmiChild.PerformClick();
                    break;
                }

            //apply autostart parameter to item
            tsmiAutostart.Checked = StartupHelper.GetStartup();

            //read show on start up parameter
            bool bShowOnStart=true;
            result=ConfigurationHelper.ReadValue("showonstart", out bShowOnStart);
            if (result!=null&&result==true)
            {
                tsmiShowOnStart.Checked = bShowOnStart;
                //show strategy on startup
                if (bShowOnStart)
                    ShowNewStrategy();
            }
        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            ShowNewStrategy();
        }

        private void niMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowNewStrategy();
            else if (e.Button == MouseButtons.Middle)
                ShowLastStrategy();
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            ShowNewStrategy();
        }

        private void tsmiShowLast_Click(object sender, EventArgs e)
        {
            ShowLastStrategy();
        }

        private void tsmiShowOnStart_Click(object sender, EventArgs e)
        {
            if (!ConfigurationHelper.WriteValue("showonstart", tsmiShowOnStart.Checked))
                tsmiShowOnStart.Checked = !tsmiShowOnStart.Checked;
        }

        private void tsmiAutostart_Click(object sender, EventArgs e)
        {
            if (!StartupHelper.SetStartup(tsmiAutostart.Checked))
                tsmiAutostart.Checked = !tsmiAutostart.Checked;
        }

        private void tsmiAutoshow_Click(object sender, EventArgs e)
        {
            var tsmiThis = ((ToolStripMenuItem) sender);
            if (ConfigurationHelper.WriteValue("autoshow", Convert.ToInt32(tsmiThis.Tag)))
            {
                if (tsmiThis.Checked)
                    foreach (ToolStripMenuItem tsmiChild in tsmiAutoshow.DropDownItems)
                        tsmiChild.Checked = false;
                tsmiThis.Checked = true;

                var iTicks = Convert.ToInt32(tsmiThis.Tag);
                _timer.Stop();
                if (iTicks>0)
                {
                    _timer.Interval = iTicks;
                    _timer.Start();
                }
            }
            else
            {
                var iChecked = 0;
                foreach (ToolStripMenuItem tsmiChild in tsmiAutoshow.DropDownItems)
                    if (tsmiChild.Checked)
                        iChecked++;
                if (iChecked > 1)
                    tsmiThis.Checked = false;
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "Oblique Strategies 1.0\r\nby Vitaly Obukhov (2010)\r\n\r\nOriginal texts from http://www.rtqe.net/",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
