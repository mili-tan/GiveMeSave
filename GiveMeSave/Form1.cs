using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GiveMeSave
{
    public partial class Form1 : MaterialForm
    {
        int min = 5;
        Icon ico = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keyEvent(Keys KeyName, byte Scan, uint Flags, uint ExtraInfo);
        public const int KEYEVENTF_KEYUP = 2;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal700, Primary.Teal800, Primary.Teal500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            mBtnStop.Enabled = false;
            labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
            timerSave.Interval = min * 60000;
            materialProgressBar.Value = min;
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            backgroundWorkerSave.RunWorkerAsync();
            if (mCheckBoxNoMsg.Checked == false)
            {
                notifyIcon1.ShowBalloonTip(1000, "已保存", DateTime.Now.ToString() + " 已自动保存", ToolTipIcon.None);
            }
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

        //private void trackBarTime_ValueChanged(object sender, EventArgs e)
        //{
        //    min = trackBarTime.Value;
        //    labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
        //    timerSave.Interval = min * 60000;
        //}

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void mBtnStart_Click(object sender, EventArgs e)
        {
            mBtnStart.Enabled = false;
            mBtnStop.Enabled = true;
            mBtnSub.Enabled = false;
            mBtnAdd.Enabled = false;
            timerSave.Enabled = true;

            notifyIcon1.Icon = ico;
            notifyIcon1.Visible = true;
            timerSave.Interval = min * 60000;

            notifyIcon1.ShowBalloonTip(2500, "已开始", "将每" + min + "分钟保存一次", ToolTipIcon.None);
        }

        private void mBtnStop_Click(object sender, EventArgs e)
        {
            mBtnStart.Enabled = true;
            mBtnStop.Enabled = false;
            mBtnSub.Enabled = true;
            mBtnAdd.Enabled = true;

            timerSave.Enabled = false;

            notifyIcon1.Icon = ico;
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(2500, "已停止", "自动保存已停止", ToolTipIcon.None);
        }

        private void mBtnSub_Click(object sender, EventArgs e)
        {
            if (min > 5)
            {
                min = min - 5;
            }
            else if (min == 5)
            {
                min = 1;
            }
            materialProgressBar.Value = min;
            labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
        }

        private void mBtnAdd_Click(object sender, EventArgs e)
        {
            if (min == 1)
            {
                min = 5;
            }
            else if (min < 100)
            {
                min = min + 5;
            }
            materialProgressBar.Value = min;
            labelTime.Text = "每" + min.ToString() + "分钟自动保存一次";
        }

    }
}
