namespace Vacation
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
            this.mcnVacation = new System.Windows.Forms.MonthCalendar();
            this.dtpWork = new System.Windows.Forms.DateTimePicker();
            this.lblVacation = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcnVacation
            // 
            this.mcnVacation.Location = new System.Drawing.Point(171, 42);
            this.mcnVacation.Name = "mcnVacation";
            this.mcnVacation.TabIndex = 10;
            this.mcnVacation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcnVacation_DateChanged);
            // 
            // dtpWork
            // 
            this.dtpWork.Location = new System.Drawing.Point(22, 42);
            this.dtpWork.Name = "dtpWork";
            this.dtpWork.Size = new System.Drawing.Size(125, 22);
            this.dtpWork.TabIndex = 9;
            this.dtpWork.ValueChanged += new System.EventHandler(this.dtpWork_ValueChanged);
            // 
            // lblVacation
            // 
            this.lblVacation.AutoSize = true;
            this.lblVacation.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblVacation.Location = new System.Drawing.Point(22, 89);
            this.lblVacation.Name = "lblVacation";
            this.lblVacation.Size = new System.Drawing.Size(56, 16);
            this.lblVacation.TabIndex = 8;
            this.lblVacation.Text = "休假日";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(158, 17);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(101, 12);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "請選擇連休日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "請輸入你的到職日：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 221);
            this.Controls.Add(this.mcnVacation);
            this.Controls.Add(this.dtpWork);
            this.Controls.Add(this.lblVacation);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcnVacation;
        private System.Windows.Forms.DateTimePicker dtpWork;
        private System.Windows.Forms.Label lblVacation;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
    }
}

