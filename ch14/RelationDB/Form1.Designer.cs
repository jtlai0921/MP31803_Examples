namespace RelationDB
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new RelationDB.NorthwindDataSet();
            this.訂貨主檔BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.訂貨主檔TableAdapter = new RelationDB.NorthwindDataSetTableAdapters.訂貨主檔TableAdapter();
            this.tableAdapterManager = new RelationDB.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.訂貨主檔DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂貨明細BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.訂貨明細TableAdapter = new RelationDB.NorthwindDataSetTableAdapters.訂貨明細TableAdapter();
            this.訂貨明細DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨主檔BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨主檔DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨明細BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨明細DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.northwindDataSet;
            this.bindingSource1.Position = 0;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 訂貨主檔BindingSource
            // 
            this.訂貨主檔BindingSource.DataMember = "訂貨主檔";
            this.訂貨主檔BindingSource.DataSource = this.northwindDataSet;
            // 
            // 訂貨主檔TableAdapter
            // 
            this.訂貨主檔TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RelationDB.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.訂貨主檔TableAdapter = this.訂貨主檔TableAdapter;
            this.tableAdapterManager.訂貨明細TableAdapter = this.訂貨明細TableAdapter;
            // 
            // 訂貨主檔DataGridView
            // 
            this.訂貨主檔DataGridView.AutoGenerateColumns = false;
            this.訂貨主檔DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.訂貨主檔DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.訂貨主檔DataGridView.DataSource = this.訂貨主檔BindingSource;
            this.訂貨主檔DataGridView.Location = new System.Drawing.Point(44, 47);
            this.訂貨主檔DataGridView.Name = "訂貨主檔DataGridView";
            this.訂貨主檔DataGridView.RowTemplate.Height = 38;
            this.訂貨主檔DataGridView.Size = new System.Drawing.Size(300, 220);
            this.訂貨主檔DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "訂單號碼";
            this.dataGridViewTextBoxColumn1.HeaderText = "訂單號碼";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "客戶編號";
            this.dataGridViewTextBoxColumn2.HeaderText = "客戶編號";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "員工編號";
            this.dataGridViewTextBoxColumn3.HeaderText = "員工編號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "訂單日期";
            this.dataGridViewTextBoxColumn4.HeaderText = "訂單日期";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "要貨日期";
            this.dataGridViewTextBoxColumn5.HeaderText = "要貨日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "送貨日期";
            this.dataGridViewTextBoxColumn6.HeaderText = "送貨日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "送貨方式";
            this.dataGridViewTextBoxColumn7.HeaderText = "送貨方式";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "運費";
            this.dataGridViewTextBoxColumn8.HeaderText = "運費";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "收貨人";
            this.dataGridViewTextBoxColumn9.HeaderText = "收貨人";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "送貨地址";
            this.dataGridViewTextBoxColumn10.HeaderText = "送貨地址";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "送貨城市";
            this.dataGridViewTextBoxColumn11.HeaderText = "送貨城市";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "送貨行政區";
            this.dataGridViewTextBoxColumn12.HeaderText = "送貨行政區";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "送貨郵遞區號";
            this.dataGridViewTextBoxColumn13.HeaderText = "送貨郵遞區號";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "送貨國家地區";
            this.dataGridViewTextBoxColumn14.HeaderText = "送貨國家地區";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // 訂貨明細BindingSource
            // 
            this.訂貨明細BindingSource.DataMember = "訂貨主檔_訂貨明細";
            this.訂貨明細BindingSource.DataSource = this.訂貨主檔BindingSource;
            // 
            // 訂貨明細TableAdapter
            // 
            this.訂貨明細TableAdapter.ClearBeforeFill = true;
            // 
            // 訂貨明細DataGridView
            // 
            this.訂貨明細DataGridView.AutoGenerateColumns = false;
            this.訂貨明細DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.訂貨明細DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.訂貨明細DataGridView.DataSource = this.訂貨明細BindingSource;
            this.訂貨明細DataGridView.Location = new System.Drawing.Point(220, 404);
            this.訂貨明細DataGridView.Name = "訂貨明細DataGridView";
            this.訂貨明細DataGridView.Size = new System.Drawing.Size(300, 220);
            this.訂貨明細DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "訂單號碼";
            this.dataGridViewTextBoxColumn15.HeaderText = "訂單號碼";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "產品編號";
            this.dataGridViewTextBoxColumn16.HeaderText = "產品編號";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "單價";
            this.dataGridViewTextBoxColumn17.HeaderText = "單價";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "數量";
            this.dataGridViewTextBoxColumn18.HeaderText = "數量";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "折扣";
            this.dataGridViewTextBoxColumn19.HeaderText = "折扣";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 684);
            this.Controls.Add(this.訂貨明細DataGridView);
            this.Controls.Add(this.訂貨主檔DataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨主檔BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨主檔DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨明細BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂貨明細DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource 訂貨主檔BindingSource;
        private NorthwindDataSetTableAdapters.訂貨主檔TableAdapter 訂貨主檔TableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NorthwindDataSetTableAdapters.訂貨明細TableAdapter 訂貨明細TableAdapter;
        private System.Windows.Forms.DataGridView 訂貨主檔DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource 訂貨明細BindingSource;
        private System.Windows.Forms.DataGridView 訂貨明細DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}

