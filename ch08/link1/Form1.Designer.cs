namespace link1
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
            this.llblWeb = new System.Windows.Forms.LinkLabel();
            this.llblapp = new System.Windows.Forms.LinkLabel();
            this.llblReadMe = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblWeb
            // 
            this.llblWeb.AutoSize = true;
            this.llblWeb.Location = new System.Drawing.Point(191, 88);
            this.llblWeb.Name = "llblWeb";
            this.llblWeb.Size = new System.Drawing.Size(53, 12);
            this.llblWeb.TabIndex = 11;
            this.llblWeb.TabStop = true;
            this.llblWeb.Text = "使用方法";
            this.llblWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWeb_LinkClicked);
            // 
            // llblapp
            // 
            this.llblapp.AutoSize = true;
            this.llblapp.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.llblapp.Location = new System.Drawing.Point(102, 88);
            this.llblapp.Name = "llblapp";
            this.llblapp.Size = new System.Drawing.Size(66, 19);
            this.llblapp.TabIndex = 10;
            this.llblapp.TabStop = true;
            this.llblapp.Text = "小算盤程式";
            this.llblapp.UseCompatibleTextRendering = true;
            this.llblapp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblapp_LinkClicked);
            // 
            // llblReadMe
            // 
            this.llblReadMe.AutoSize = true;
            this.llblReadMe.Location = new System.Drawing.Point(22, 88);
            this.llblReadMe.Name = "llblReadMe";
            this.llblReadMe.Size = new System.Drawing.Size(65, 12);
            this.llblReadMe.TabIndex = 9;
            this.llblReadMe.TabStop = true;
            this.llblReadMe.Text = "小算盤簡介";
            this.llblReadMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblReadMe_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 12);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 116);
            this.Controls.Add(this.llblWeb);
            this.Controls.Add(this.llblapp);
            this.Controls.Add(this.llblReadMe);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblWeb;
        private System.Windows.Forms.LinkLabel llblapp;
        private System.Windows.Forms.LinkLabel llblReadMe;
        private System.Windows.Forms.Label lblTitle;
    }
}

