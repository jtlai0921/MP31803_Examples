namespace NoteBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuAP = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCD = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuPC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNB = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPAD = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuType,
            this.mnuAdd,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuType
            // 
            this.mnuType.Name = "mnuType";
            this.mnuType.Size = new System.Drawing.Size(43, 20);
            this.mnuType.Text = "機型";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(43, 20);
            this.mnuAdd.Text = "配件";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(59, 20);
            this.mnuExit.Text = "結束(&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuHD,
            this.cmnuAP,
            this.cmnuCD});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 70);
            // 
            // cmnuHD
            // 
            this.cmnuHD.Name = "cmnuHD";
            this.cmnuHD.Size = new System.Drawing.Size(152, 22);
            this.cmnuHD.Text = "500G行動硬碟";
            this.cmnuHD.Click += new System.EventHandler(this.cmnuHD_Click);
            // 
            // cmnuAP
            // 
            this.cmnuAP.Name = "cmnuAP";
            this.cmnuAP.Size = new System.Drawing.Size(152, 22);
            this.cmnuAP.Text = "無線AP分享器";
            this.cmnuAP.Click += new System.EventHandler(this.cmnuAP_Click);
            // 
            // cmnuCD
            // 
            this.cmnuCD.Name = "cmnuCD";
            this.cmnuCD.Size = new System.Drawing.Size(152, 22);
            this.cmnuCD.Text = "外接式光碟機";
            this.cmnuCD.Click += new System.EventHandler(this.cmnuCD_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuPC,
            this.cmnuNB,
            this.cmnuPAD});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // cmnuPC
            // 
            this.cmnuPC.Name = "cmnuPC";
            this.cmnuPC.Size = new System.Drawing.Size(152, 22);
            this.cmnuPC.Text = "桌上型電腦";
            this.cmnuPC.Click += new System.EventHandler(this.cmnuPC_Click);
            // 
            // cmnuNB
            // 
            this.cmnuNB.Name = "cmnuNB";
            this.cmnuNB.Size = new System.Drawing.Size(134, 22);
            this.cmnuNB.Text = "筆記型電腦";
            // 
            // cmnuPAD
            // 
            this.cmnuPAD.Name = "cmnuPAD";
            this.cmnuPAD.Size = new System.Drawing.Size(134, 22);
            this.cmnuPAD.Text = "平板電腦";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("新細明體", 20F);
            this.lblTotal.Location = new System.Drawing.Point(24, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(214, 35);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "金額：";
            // 
            // lblAdd
            // 
            this.lblAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdd.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAdd.Location = new System.Drawing.Point(24, 115);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(214, 69);
            this.lblAdd.TabIndex = 11;
            this.lblAdd.Text = "label2";
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblType.Location = new System.Drawing.Point(24, 55);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(216, 28);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "購買的配件：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "購買的機型：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 256);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuType;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmnuHD;
        private System.Windows.Forms.ToolStripMenuItem cmnuAP;
        private System.Windows.Forms.ToolStripMenuItem cmnuCD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuPC;
        private System.Windows.Forms.ToolStripMenuItem cmnuNB;
        private System.Windows.Forms.ToolStripMenuItem cmnuPAD;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

