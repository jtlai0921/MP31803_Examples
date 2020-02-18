namespace BubbleTea
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
            this.label1 = new System.Windows.Forms.Label();
            this.btbOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTea3 = new System.Windows.Forms.RadioButton();
            this.rdbTea2 = new System.Windows.Forms.RadioButton();
            this.rdbTea1 = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSizeL = new System.Windows.Forms.RadioButton();
            this.rdbSizeS = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "手搖茶飲專賣店";
            // 
            // btbOK
            // 
            this.btbOK.Location = new System.Drawing.Point(197, 12);
            this.btbOK.Name = "btbOK";
            this.btbOK.Size = new System.Drawing.Size(75, 23);
            this.btbOK.TabIndex = 1;
            this.btbOK.Text = "結帳";
            this.btbOK.UseVisualStyleBackColor = true;
            this.btbOK.Click += new System.EventHandler(this.btbOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTea3);
            this.groupBox1.Controls.Add(this.rdbTea2);
            this.groupBox1.Controls.Add(this.rdbTea1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "類別";
            // 
            // rdbTea3
            // 
            this.rdbTea3.AutoSize = true;
            this.rdbTea3.Location = new System.Drawing.Point(11, 79);
            this.rdbTea3.Name = "rdbTea3";
            this.rdbTea3.Size = new System.Drawing.Size(47, 16);
            this.rdbTea3.TabIndex = 2;
            this.rdbTea3.TabStop = true;
            this.rdbTea3.Text = "奶茶";
            this.rdbTea3.UseVisualStyleBackColor = true;
            // 
            // rdbTea2
            // 
            this.rdbTea2.AutoSize = true;
            this.rdbTea2.Location = new System.Drawing.Point(11, 50);
            this.rdbTea2.Name = "rdbTea2";
            this.rdbTea2.Size = new System.Drawing.Size(47, 16);
            this.rdbTea2.TabIndex = 1;
            this.rdbTea2.TabStop = true;
            this.rdbTea2.Text = "綠茶";
            this.rdbTea2.UseVisualStyleBackColor = true;
            // 
            // rdbTea1
            // 
            this.rdbTea1.AutoSize = true;
            this.rdbTea1.Location = new System.Drawing.Point(11, 21);
            this.rdbTea1.Name = "rdbTea1";
            this.rdbTea1.Size = new System.Drawing.Size(47, 16);
            this.rdbTea1.TabIndex = 0;
            this.rdbTea1.TabStop = true;
            this.rdbTea1.Text = "紅茶";
            this.rdbTea1.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(12, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSizeL);
            this.groupBox2.Controls.Add(this.rdbSizeS);
            this.groupBox2.Location = new System.Drawing.Point(102, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大小";
            // 
            // rdbSizeL
            // 
            this.rdbSizeL.AutoSize = true;
            this.rdbSizeL.Location = new System.Drawing.Point(11, 50);
            this.rdbSizeL.Name = "rdbSizeL";
            this.rdbSizeL.Size = new System.Drawing.Size(47, 16);
            this.rdbSizeL.TabIndex = 1;
            this.rdbSizeL.TabStop = true;
            this.rdbSizeL.Text = "大杯";
            this.rdbSizeL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeS
            // 
            this.rdbSizeS.AutoSize = true;
            this.rdbSizeS.Location = new System.Drawing.Point(11, 21);
            this.rdbSizeS.Name = "rdbSizeS";
            this.rdbSizeS.Size = new System.Drawing.Size(47, 16);
            this.rdbSizeS.TabIndex = 0;
            this.rdbSizeS.TabStop = true;
            this.rdbSizeS.Text = "小杯";
            this.rdbSizeS.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk3);
            this.groupBox3.Controls.Add(this.chk2);
            this.groupBox3.Controls.Add(this.chk1);
            this.groupBox3.Location = new System.Drawing.Point(192, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 105);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(9, 79);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(72, 16);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "自備容器";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(9, 50);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(60, 16);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "塑膠袋";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(9, 21);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(48, 16);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "加冰";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 194);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btbOK);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTea3;
        private System.Windows.Forms.RadioButton rdbTea2;
        private System.Windows.Forms.RadioButton rdbTea1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSizeL;
        private System.Windows.Forms.RadioButton rdbSizeS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
    }
}

