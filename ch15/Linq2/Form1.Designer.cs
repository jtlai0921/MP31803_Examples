﻿namespace Linq2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnEmpId = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnSelEmpById = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(960, 318);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "排序規則";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "查詢員工編號";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(201, 452);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(135, 36);
            this.txtEmpId.TabIndex = 2;
            // 
            // btnEmpId
            // 
            this.btnEmpId.Location = new System.Drawing.Point(201, 378);
            this.btnEmpId.Name = "btnEmpId";
            this.btnEmpId.Size = new System.Drawing.Size(135, 45);
            this.btnEmpId.TabIndex = 3;
            this.btnEmpId.Text = "員工編號";
            this.btnEmpId.UseVisualStyleBackColor = true;
            this.btnEmpId.Click += new System.EventHandler(this.btnEmpId_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(419, 378);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(135, 45);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "薪資";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(648, 378);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(135, 45);
            this.btnDate.TabIndex = 3;
            this.btnDate.Text = "雇用日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnSelEmpById
            // 
            this.btnSelEmpById.Location = new System.Drawing.Point(419, 448);
            this.btnSelEmpById.Name = "btnSelEmpById";
            this.btnSelEmpById.Size = new System.Drawing.Size(135, 45);
            this.btnSelEmpById.TabIndex = 3;
            this.btnSelEmpById.Text = "單筆查詢";
            this.btnSelEmpById.UseVisualStyleBackColor = true;
            this.btnSelEmpById.Click += new System.EventHandler(this.btnSelEmpById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 525);
            this.Controls.Add(this.btnSelEmpById);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "員工資料表查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnEmpId;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSelEmpById;
    }
}

