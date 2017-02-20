namespace GiveMeSave
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mBtnStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mCheckBoxNoMsg = new MaterialSkin.Controls.MaterialCheckBox();
            this.mBtnStop = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTime
            // 
            this.trackBarTime.Location = new System.Drawing.Point(12, 103);
            this.trackBarTime.Maximum = 60;
            this.trackBarTime.Minimum = 1;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(378, 45);
            this.trackBarTime.SmallChange = 5;
            this.trackBarTime.TabIndex = 2;
            this.trackBarTime.Value = 5;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.trackBarTime_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(12, 73);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(174, 21);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "每XX分钟自动保存一次";
            // 
            // timerSave
            // 
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // backgroundWorkerSave
            // 
            this.backgroundWorkerSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSave_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "给我存 - 定时自动保存工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // mBtnStart
            // 
            this.mBtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnStart.AutoSize = true;
            this.mBtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnStart.Depth = 0;
            this.mBtnStart.Icon = null;
            this.mBtnStart.Location = new System.Drawing.Point(345, 162);
            this.mBtnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnStart.Name = "mBtnStart";
            this.mBtnStart.Primary = false;
            this.mBtnStart.Size = new System.Drawing.Size(48, 36);
            this.mBtnStart.TabIndex = 5;
            this.mBtnStart.Text = "开始";
            this.mBtnStart.UseVisualStyleBackColor = true;
            this.mBtnStart.Click += new System.EventHandler(this.mBtnStart_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 154);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(407, 1);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mCheckBoxNoMsg
            // 
            this.mCheckBoxNoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mCheckBoxNoMsg.AutoSize = true;
            this.mCheckBoxNoMsg.Depth = 0;
            this.mCheckBoxNoMsg.Font = new System.Drawing.Font("Noto Sans CJK SC Medium", 10F);
            this.mCheckBoxNoMsg.Location = new System.Drawing.Point(12, 163);
            this.mCheckBoxNoMsg.Margin = new System.Windows.Forms.Padding(0);
            this.mCheckBoxNoMsg.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mCheckBoxNoMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCheckBoxNoMsg.Name = "mCheckBoxNoMsg";
            this.mCheckBoxNoMsg.Ripple = true;
            this.mCheckBoxNoMsg.Size = new System.Drawing.Size(112, 30);
            this.mCheckBoxNoMsg.TabIndex = 7;
            this.mCheckBoxNoMsg.Text = "保存后不提示";
            this.mCheckBoxNoMsg.UseVisualStyleBackColor = true;
            // 
            // mBtnStop
            // 
            this.mBtnStop.AutoSize = true;
            this.mBtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnStop.Depth = 0;
            this.mBtnStop.Icon = null;
            this.mBtnStop.Location = new System.Drawing.Point(345, 200);
            this.mBtnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnStop.Name = "mBtnStop";
            this.mBtnStop.Primary = false;
            this.mBtnStop.Size = new System.Drawing.Size(48, 36);
            this.mBtnStop.TabIndex = 8;
            this.mBtnStop.Text = "停止";
            this.mBtnStop.UseVisualStyleBackColor = true;
            this.mBtnStop.Click += new System.EventHandler(this.mBtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 203);
            this.Controls.Add(this.mBtnStop);
            this.Controls.Add(this.mCheckBoxNoMsg);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mBtnStart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.trackBarTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "给我存";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerSave;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialFlatButton mBtnStart;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox mCheckBoxNoMsg;
        private MaterialSkin.Controls.MaterialFlatButton mBtnStop;
    }
}

