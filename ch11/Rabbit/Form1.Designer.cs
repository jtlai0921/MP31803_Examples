﻿namespace Rabbit
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
            this.picHat = new System.Windows.Forms.PictureBox();
            this.imgHat = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).BeginInit();
            this.SuspendLayout();
            // 
            // picHat
            // 
            this.picHat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHat.Location = new System.Drawing.Point(111, 90);
            this.picHat.Name = "picHat";
            this.picHat.Size = new System.Drawing.Size(60, 80);
            this.picHat.TabIndex = 0;
            this.picHat.TabStop = false;
            this.picHat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHat_MouseDown);
            this.picHat.MouseEnter += new System.EventHandler(this.picHat_MouseEnter);
            this.picHat.MouseLeave += new System.EventHandler(this.picHat_MouseLeave);
            this.picHat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picHat_MouseMove);
            this.picHat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picHat_MouseUp);
            // 
            // imgHat
            // 
            this.imgHat.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgHat.ImageSize = new System.Drawing.Size(60, 80);
            this.imgHat.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picHat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHat;
        private System.Windows.Forms.ImageList imgHat;
    }
}

