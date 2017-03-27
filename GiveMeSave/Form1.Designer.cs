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
            this.labelTime = new System.Windows.Forms.Label();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerSave = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mBtnStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mCheckBoxNoMsg = new MaterialSkin.Controls.MaterialCheckBox();
            this.mBtnStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.mBtnSub = new MaterialSkin.Controls.MaterialFlatButton();
            this.mBtnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Noto Sans CJK SC Regular", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(4, 82);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(215, 30);
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
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon1.Text = "给我存 - 定时自动保存工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShow,
            this.menuItemStop,
            this.toolStripSeparator1,
            this.menuItemAbout,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(172, 126);
            // 
            // menuItemShow
            // 
            this.menuItemShow.Name = "menuItemShow";
            this.menuItemShow.Size = new System.Drawing.Size(171, 22);
            this.menuItemShow.Text = "显示GiveMeSave";
            this.menuItemShow.Click += new System.EventHandler(this.menuItemShow_Click);
            // 
            // menuItemStop
            // 
            this.menuItemStop.Enabled = false;
            this.menuItemStop.Name = "menuItemStop";
            this.menuItemStop.Size = new System.Drawing.Size(171, 22);
            this.menuItemStop.Text = "停止自动保存";
            this.menuItemStop.Click += new System.EventHandler(this.menuItemStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(171, 22);
            this.menuItemAbout.Text = "关于";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(171, 22);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // mBtnStart
            // 
            this.mBtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnStart.AutoSize = true;
            this.mBtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnStart.Depth = 0;
            this.mBtnStart.Icon = null;
            this.mBtnStart.Location = new System.Drawing.Point(362, 208);
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
            this.materialDivider1.Location = new System.Drawing.Point(-2, 201);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(479, 1);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mCheckBoxNoMsg
            // 
            this.mCheckBoxNoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mCheckBoxNoMsg.AutoSize = true;
            this.mCheckBoxNoMsg.Depth = 0;
            this.mCheckBoxNoMsg.Font = new System.Drawing.Font("Noto Sans CJK SC Medium", 10F);
            this.mCheckBoxNoMsg.Location = new System.Drawing.Point(9, 209);
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
            this.mBtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnStop.AutoSize = true;
            this.mBtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnStop.Depth = 0;
            this.mBtnStop.Icon = null;
            this.mBtnStop.Location = new System.Drawing.Point(411, 208);
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
            // materialProgressBar
            // 
            this.materialProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar.Depth = 0;
            this.materialProgressBar.Location = new System.Drawing.Point(9, 129);
            this.materialProgressBar.Minimum = 1;
            this.materialProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar.Name = "materialProgressBar";
            this.materialProgressBar.Size = new System.Drawing.Size(449, 5);
            this.materialProgressBar.Step = 5;
            this.materialProgressBar.TabIndex = 9;
            this.materialProgressBar.Value = 1;
            // 
            // mBtnSub
            // 
            this.mBtnSub.AutoSize = true;
            this.mBtnSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnSub.BackColor = System.Drawing.Color.Transparent;
            this.mBtnSub.Depth = 0;
            this.mBtnSub.Icon = global::GiveMeSave.Properties.Resources.minus;
            this.mBtnSub.Location = new System.Drawing.Point(9, 149);
            this.mBtnSub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnSub.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnSub.Name = "mBtnSub";
            this.mBtnSub.Primary = false;
            this.mBtnSub.Size = new System.Drawing.Size(120, 36);
            this.mBtnSub.TabIndex = 10;
            this.mBtnSub.Text = "Subtract";
            this.mBtnSub.UseVisualStyleBackColor = false;
            this.mBtnSub.Click += new System.EventHandler(this.mBtnSub_Click);
            // 
            // mBtnAdd
            // 
            this.mBtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mBtnAdd.AutoSize = true;
            this.mBtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtnAdd.Depth = 0;
            this.mBtnAdd.Icon = global::GiveMeSave.Properties.Resources.plus;
            this.mBtnAdd.Location = new System.Drawing.Point(381, 149);
            this.mBtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnAdd.Name = "mBtnAdd";
            this.mBtnAdd.Primary = false;
            this.mBtnAdd.Size = new System.Drawing.Size(77, 36);
            this.mBtnAdd.TabIndex = 11;
            this.mBtnAdd.Text = "Add";
            this.mBtnAdd.UseVisualStyleBackColor = true;
            this.mBtnAdd.Click += new System.EventHandler(this.mBtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 250);
            this.Controls.Add(this.mBtnAdd);
            this.Controls.Add(this.mBtnSub);
            this.Controls.Add(this.materialProgressBar);
            this.Controls.Add(this.mBtnStop);
            this.Controls.Add(this.mCheckBoxNoMsg);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.mBtnStart);
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "给我存";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerSave;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialFlatButton mBtnStart;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox mCheckBoxNoMsg;
        private MaterialSkin.Controls.MaterialFlatButton mBtnStop;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;
        private MaterialSkin.Controls.MaterialFlatButton mBtnSub;
        private MaterialSkin.Controls.MaterialFlatButton mBtnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemShow;
        private System.Windows.Forms.ToolStripMenuItem menuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

