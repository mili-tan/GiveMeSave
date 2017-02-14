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
            this.buttonSaveStart = new System.Windows.Forms.Button();
            this.buttonSaveStop = new System.Windows.Forms.Button();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxNoMsg = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveStart
            // 
            this.buttonSaveStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveStart.Location = new System.Drawing.Point(13, 13);
            this.buttonSaveStart.Name = "buttonSaveStart";
            this.buttonSaveStart.Size = new System.Drawing.Size(359, 23);
            this.buttonSaveStart.TabIndex = 0;
            this.buttonSaveStart.Text = "开始自动保存";
            this.buttonSaveStart.UseVisualStyleBackColor = true;
            this.buttonSaveStart.Click += new System.EventHandler(this.buttonSaveStart_Click);
            // 
            // buttonSaveStop
            // 
            this.buttonSaveStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveStop.Location = new System.Drawing.Point(13, 13);
            this.buttonSaveStop.Name = "buttonSaveStop";
            this.buttonSaveStop.Size = new System.Drawing.Size(359, 23);
            this.buttonSaveStop.TabIndex = 1;
            this.buttonSaveStop.Text = "停止自动保存";
            this.buttonSaveStop.UseVisualStyleBackColor = true;
            this.buttonSaveStop.Click += new System.EventHandler(this.buttonSaveStop_Click);
            // 
            // trackBarTime
            // 
            this.trackBarTime.Location = new System.Drawing.Point(13, 43);
            this.trackBarTime.Maximum = 60;
            this.trackBarTime.Minimum = 1;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(359, 45);
            this.trackBarTime.SmallChange = 5;
            this.trackBarTime.TabIndex = 2;
            this.trackBarTime.Value = 5;
            this.trackBarTime.ValueChanged += new System.EventHandler(this.trackBarTime_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(12, 80);
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
            // checkBoxNoMsg
            // 
            this.checkBoxNoMsg.AutoSize = true;
            this.checkBoxNoMsg.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxNoMsg.Location = new System.Drawing.Point(247, 79);
            this.checkBoxNoMsg.Name = "checkBoxNoMsg";
            this.checkBoxNoMsg.Size = new System.Drawing.Size(125, 25);
            this.checkBoxNoMsg.TabIndex = 4;
            this.checkBoxNoMsg.Text = "保存后不提示";
            this.checkBoxNoMsg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 119);
            this.Controls.Add(this.checkBoxNoMsg);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.buttonSaveStop);
            this.Controls.Add(this.buttonSaveStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "给我存";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveStart;
        private System.Windows.Forms.Button buttonSaveStop;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerSave;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBoxNoMsg;
    }
}

