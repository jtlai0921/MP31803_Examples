namespace hello
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(211, 71);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(77, 28);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "結束";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(115, 71);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(77, 28);
            this.btnDate.TabIndex = 6;
            this.btnDate.Text = "日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(19, 71);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(77, 28);
            this.btnHi.TabIndex = 5;
            this.btnHi.Text = "問侯";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(17, 27);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(83, 24);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "Hello！";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(299, 121);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.lblShow);
            this.Name = "Form1";
            this.Text = " 我的第一個程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Label lblShow;
    }
}

