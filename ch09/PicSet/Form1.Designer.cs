namespace PicSet
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
            this.picShow = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLoad = new System.Windows.Forms.RadioButton();
            this.rdbNull = new System.Windows.Forms.RadioButton();
            this.rdbSize1 = new System.Windows.Forms.RadioButton();
            this.rdbSize2 = new System.Windows.Forms.RadioButton();
            this.rdbSize3 = new System.Windows.Forms.RadioButton();
            this.rdbSize4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Location = new System.Drawing.Point(13, 14);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(183, 217);
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSize4);
            this.groupBox1.Controls.Add(this.rdbSize3);
            this.groupBox1.Controls.Add(this.rdbSize2);
            this.groupBox1.Controls.Add(this.rdbSize1);
            this.groupBox1.Location = new System.Drawing.Point(202, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大小";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNull);
            this.groupBox2.Controls.Add(this.rdbLoad);
            this.groupBox2.Location = new System.Drawing.Point(202, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "顯示";
            // 
            // rdbLoad
            // 
            this.rdbLoad.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbLoad.AutoSize = true;
            this.rdbLoad.Location = new System.Drawing.Point(6, 35);
            this.rdbLoad.Name = "rdbLoad";
            this.rdbLoad.Size = new System.Drawing.Size(39, 22);
            this.rdbLoad.TabIndex = 0;
            this.rdbLoad.TabStop = true;
            this.rdbLoad.Text = "顯示";
            this.rdbLoad.UseVisualStyleBackColor = true;
            this.rdbLoad.CheckedChanged += new System.EventHandler(this.rdbLoad_CheckedChanged);
            // 
            // rdbNull
            // 
            this.rdbNull.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNull.AutoSize = true;
            this.rdbNull.Location = new System.Drawing.Point(65, 35);
            this.rdbNull.Name = "rdbNull";
            this.rdbNull.Size = new System.Drawing.Size(39, 22);
            this.rdbNull.TabIndex = 1;
            this.rdbNull.TabStop = true;
            this.rdbNull.Text = "隱藏";
            this.rdbNull.UseVisualStyleBackColor = true;
            this.rdbNull.CheckedChanged += new System.EventHandler(this.rdbNull_CheckedChanged);
            // 
            // rdbSize1
            // 
            this.rdbSize1.AutoSize = true;
            this.rdbSize1.Location = new System.Drawing.Point(8, 22);
            this.rdbSize1.Name = "rdbSize1";
            this.rdbSize1.Size = new System.Drawing.Size(59, 16);
            this.rdbSize1.TabIndex = 0;
            this.rdbSize1.TabStop = true;
            this.rdbSize1.Text = "原尺寸";
            this.rdbSize1.UseVisualStyleBackColor = true;
            this.rdbSize1.CheckedChanged += new System.EventHandler(this.rdbSize1_CheckedChanged);
            // 
            // rdbSize2
            // 
            this.rdbSize2.AutoSize = true;
            this.rdbSize2.Location = new System.Drawing.Point(8, 47);
            this.rdbSize2.Name = "rdbSize2";
            this.rdbSize2.Size = new System.Drawing.Size(47, 16);
            this.rdbSize2.TabIndex = 1;
            this.rdbSize2.TabStop = true;
            this.rdbSize2.Text = "放大";
            this.rdbSize2.UseVisualStyleBackColor = true;
            this.rdbSize2.CheckedChanged += new System.EventHandler(this.rdbSize2_CheckedChanged);
            // 
            // rdbSize3
            // 
            this.rdbSize3.AutoSize = true;
            this.rdbSize3.Location = new System.Drawing.Point(8, 72);
            this.rdbSize3.Name = "rdbSize3";
            this.rdbSize3.Size = new System.Drawing.Size(83, 16);
            this.rdbSize3.TabIndex = 2;
            this.rdbSize3.TabStop = true;
            this.rdbSize3.Text = "原尺寸置中";
            this.rdbSize3.UseVisualStyleBackColor = true;
            this.rdbSize3.CheckedChanged += new System.EventHandler(this.rdbSize3_CheckedChanged);
            // 
            // rdbSize4
            // 
            this.rdbSize4.AutoSize = true;
            this.rdbSize4.Location = new System.Drawing.Point(8, 97);
            this.rdbSize4.Name = "rdbSize4";
            this.rdbSize4.Size = new System.Drawing.Size(83, 16);
            this.rdbSize4.TabIndex = 3;
            this.rdbSize4.TabStop = true;
            this.rdbSize4.Text = "等比例放大";
            this.rdbSize4.UseVisualStyleBackColor = true;
            this.rdbSize4.CheckedChanged += new System.EventHandler(this.rdbSize4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 246);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSize4;
        private System.Windows.Forms.RadioButton rdbSize3;
        private System.Windows.Forms.RadioButton rdbSize2;
        private System.Windows.Forms.RadioButton rdbSize1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNull;
        private System.Windows.Forms.RadioButton rdbLoad;
    }
}

