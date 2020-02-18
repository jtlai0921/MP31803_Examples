namespace Alarm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tbtnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ttxtSecond = new System.Windows.Forms.ToolStripTextBox();
            this.tcboSet = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.spgbSecond = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSecond = new System.Windows.Forms.Label();
            this.tmrRun = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnStart,
            this.tbtnPause,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.ttxtSecond,
            this.tcboSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnStart
            // 
            this.tbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnStart.Image = global::Alarm.Properties.Resources.play;
            this.tbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStart.Name = "tbtnStart";
            this.tbtnStart.Size = new System.Drawing.Size(23, 22);
            this.tbtnStart.Text = "toolStripButton1";
            this.tbtnStart.Click += new System.EventHandler(this.tbtnStart_Click);
            // 
            // tbtnPause
            // 
            this.tbtnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPause.Image = global::Alarm.Properties.Resources.pause;
            this.tbtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPause.Name = "tbtnPause";
            this.tbtnPause.Size = new System.Drawing.Size(23, 22);
            this.tbtnPause.Text = "toolStripButton2";
            this.tbtnPause.Click += new System.EventHandler(this.tbtnPause_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel1.Text = "倒數秒數：";
            // 
            // ttxtSecond
            // 
            this.ttxtSecond.Name = "ttxtSecond";
            this.ttxtSecond.Size = new System.Drawing.Size(40, 25);
            // 
            // tcboSet
            // 
            this.tcboSet.Items.AddRange(new object[] {
            "灰底",
            "黑底",
            "白底"});
            this.tcboSet.Name = "tcboSet";
            this.tcboSet.Size = new System.Drawing.Size(75, 25);
            this.tcboSet.SelectedIndexChanged += new System.EventHandler(this.tcboSet_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblMsg,
            this.spgbSecond});
            this.statusStrip1.Location = new System.Drawing.Point(0, 94);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(255, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblMsg
            // 
            this.slblMsg.Name = "slblMsg";
            this.slblMsg.Size = new System.Drawing.Size(128, 17);
            this.slblMsg.Text = "toolStripStatusLabel1";
            // 
            // spgbSecond
            // 
            this.spgbSecond.Name = "spgbSecond";
            this.spgbSecond.Size = new System.Drawing.Size(100, 16);
            // 
            // lblSecond
            // 
            this.lblSecond.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSecond.Location = new System.Drawing.Point(10, 32);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(236, 52);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "label1";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrRun
            // 
            this.tmrRun.Tick += new System.EventHandler(this.tmrRun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 116);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnStart;
        private System.Windows.Forms.ToolStripButton tbtnPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ttxtSecond;
        private System.Windows.Forms.ToolStripComboBox tcboSet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblMsg;
        private System.Windows.Forms.ToolStripProgressBar spgbSecond;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Timer tmrRun;
    }
}

