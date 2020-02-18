namespace Animation
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
            this.tmrRun = new System.Windows.Forms.Timer(this.components);
            this.picBird = new System.Windows.Forms.PictureBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.vsbHeight = new System.Windows.Forms.VScrollBar();
            this.tkbSpeed = new System.Windows.Forms.TrackBar();
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRun
            // 
            this.tmrRun.Tick += new System.EventHandler(this.tmrRun_Tick);
            // 
            // picBird
            // 
            this.picBird.Location = new System.Drawing.Point(365, 41);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(50, 50);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 20;
            this.picBird.TabStop = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(16, 189);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(33, 12);
            this.lblSpeed.TabIndex = 19;
            this.lblSpeed.Text = "label3";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(259, 189);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(33, 12);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Text = "label2";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(329, 147);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(33, 12);
            this.lblHeight.TabIndex = 17;
            this.lblHeight.Text = "label1";
            // 
            // vsbHeight
            // 
            this.vsbHeight.Location = new System.Drawing.Point(387, 138);
            this.vsbHeight.Name = "vsbHeight";
            this.vsbHeight.Size = new System.Drawing.Size(18, 96);
            this.vsbHeight.TabIndex = 16;
            this.vsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbHeight_Scroll);
            // 
            // tkbSpeed
            // 
            this.tkbSpeed.Location = new System.Drawing.Point(94, 189);
            this.tkbSpeed.Name = "tkbSpeed";
            this.tkbSpeed.Size = new System.Drawing.Size(130, 45);
            this.tkbSpeed.TabIndex = 15;
            this.tkbSpeed.Scroll += new System.EventHandler(this.tkbSpeed_Scroll);
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(261, 205);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(114, 19);
            this.hsbWidth.TabIndex = 14;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 249);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.vsbHeight);
            this.Controls.Add(this.tkbSpeed);
            this.Controls.Add(this.hsbWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrRun;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.VScrollBar vsbHeight;
        private System.Windows.Forms.TrackBar tkbSpeed;
        private System.Windows.Forms.HScrollBar hsbWidth;
    }
}

