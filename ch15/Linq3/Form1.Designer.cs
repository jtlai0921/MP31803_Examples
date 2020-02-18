namespace Linq3
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
            this.lblShow = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnSelEmpById = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnEmpId = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(932, 443);
            this.lblShow.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(107, 30);
            this.lblShow.TabIndex = 39;
            this.lblShow.Text = "lblShow";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(280, 519);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(156, 36);
            this.txtEmpId.TabIndex = 38;
            // 
            // btnSelEmpById
            // 
            this.btnSelEmpById.Location = new System.Drawing.Point(495, 515);
            this.btnSelEmpById.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSelEmpById.Name = "btnSelEmpById";
            this.btnSelEmpById.Size = new System.Drawing.Size(163, 46);
            this.btnSelEmpById.TabIndex = 37;
            this.btnSelEmpById.Text = "單筆查詢";
            this.btnSelEmpById.UseVisualStyleBackColor = true;
            this.btnSelEmpById.Click += new System.EventHandler(this.btnSelEmpById_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(57, 525);
            this.Label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(193, 30);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "查詢員工編號";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(122, 449);
            this.Label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 30);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "排序規則";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(694, 443);
            this.btnDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(156, 46);
            this.btnDate.TabIndex = 32;
            this.btnDate.Text = "雇用日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(495, 443);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(156, 46);
            this.btnSalary.TabIndex = 33;
            this.btnSalary.Text = "薪資";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnEmpId
            // 
            this.btnEmpId.Location = new System.Drawing.Point(284, 443);
            this.btnEmpId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEmpId.Name = "btnEmpId";
            this.btnEmpId.Size = new System.Drawing.Size(156, 46);
            this.btnEmpId.TabIndex = 34;
            this.btnEmpId.Text = "員工編號\r\n";
            this.btnEmpId.UseVisualStyleBackColor = true;
            this.btnEmpId.Click += new System.EventHandler(this.btnEmpId_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 360);
            this.dataGridView1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 603);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.btnSelEmpById);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEmpId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "員工資料查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnSelEmpById;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnEmpId;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

