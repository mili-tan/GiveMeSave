using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace GiveMeSave
{
    public partial class Form1 : Form
    {
        int min = 5;
        Icon ico = new Icon("icon.ico");

        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keyEvent(Keys KeyName, byte Scan, uint Flags, uint ExtraInfo);
        public const int KEYEVENTF_KEYUP = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSaveStop.Hide();
            labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
            timerSave.Interval = min * 60000;
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            backgroundWorkerSave.RunWorkerAsync();
            notifyIcon1.ShowBalloonTip(1000, "已自动保存", DateTime.Now.ToString() + "已保存", ToolTipIcon.None);
        }

        private void buttonSaveStart_Click(object sender, EventArgs e)
        {
            buttonSaveStart.Hide();
            buttonSaveStop.Show();
            trackBarTime.Enabled = false;
            timerSave.Enabled = true;

            notifyIcon1.Icon = ico;
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(1000, "自动保存已开始", "\r每"+min+"分钟保存一次",ToolTipIcon.None);
        }

        private void backgroundWorkerSave_DoWork(object sender, DoWorkEventArgs e)
        {
            keyEvent(Keys.ControlKey, 0, 0, 0);
            keyEvent(Keys.S, 0, 0, 0);
            keyEvent(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);

            Thread.Sleep(500);

            keyEvent(Keys.ControlKey, 0, 0, 0);
            keyEvent(Keys.S, 0, 0, 0);
            keyEvent(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
        }

        private void trackBarTime_ValueChanged(object sender, EventArgs e)
        {
            min = trackBarTime.Value;
            labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
            timerSave.Interval = min * 60000;
        }

        private void buttonSaveStop_Click(object sender, EventArgs e)
        {
            buttonSaveStart.Show();
            buttonSaveStop.Hide();
            trackBarTime.Enabled = true;
            timerSave.Enabled = false;

            notifyIcon1.Icon = ico;
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(1000, "已停止", "自动保存已停止", ToolTipIcon.None);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Activate();
                ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = ico;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }
    }
}
