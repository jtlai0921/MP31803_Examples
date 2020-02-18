namespace EditDB1
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
            System.Windows.Forms.Label 員工編號Label;
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 信箱Label;
            System.Windows.Forms.Label 薪資Label;
            System.Windows.Forms.Label 雇用日期Label;
            System.Windows.Forms.Label 是否已婚Label;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new EditDB1.Database1DataSet();
            this.員工BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.員工TableAdapter = new EditDB1.Database1DataSetTableAdapters.員工TableAdapter();
            this.tableAdapterManager = new EditDB1.Database1DataSetTableAdapters.TableAdapterManager();
            this.員工編號TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.信箱TextBox = new System.Windows.Forms.TextBox();
            this.薪資TextBox = new System.Windows.Forms.TextBox();
            this.雇用日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.是否已婚CheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.瀏覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新到資料庫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顯示記錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.第一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最末筆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            員工編號Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            信箱Label = new System.Windows.Forms.Label();
            薪資Label = new System.Windows.Forms.Label();
            雇用日期Label = new System.Windows.Forms.Label();
            是否已婚Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 員工BindingSource
            // 
            this.員工BindingSource.DataMember = "員工";
            this.員工BindingSource.DataSource = this.database1DataSet;
            // 
            // 員工TableAdapter
            // 
            this.員工TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EditDB1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.員工TableAdapter = this.員工TableAdapter;
            // 
            // 員工編號Label
            // 
            員工編號Label.AutoSize = true;
            員工編號Label.Location = new System.Drawing.Point(78, 94);
            員工編號Label.Name = "員工編號Label";
            員工編號Label.Size = new System.Drawing.Size(112, 24);
            員工編號Label.TabIndex = 0;
            員工編號Label.Text = "員工編號:";
            // 
            // 員工編號TextBox
            // 
            this.員工編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "員工編號", true));
            this.員工編號TextBox.Location = new System.Drawing.Point(218, 91);
            this.員工編號TextBox.Name = "員工編號TextBox";
            this.員工編號TextBox.Size = new System.Drawing.Size(276, 36);
            this.員工編號TextBox.TabIndex = 1;
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(78, 154);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(64, 24);
            姓名Label.TabIndex = 2;
            姓名Label.Text = "姓名:";
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(218, 151);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(276, 36);
            this.姓名TextBox.TabIndex = 3;
            // 
            // 信箱Label
            // 
            信箱Label.AutoSize = true;
            信箱Label.Location = new System.Drawing.Point(78, 214);
            信箱Label.Name = "信箱Label";
            信箱Label.Size = new System.Drawing.Size(64, 24);
            信箱Label.TabIndex = 4;
            信箱Label.Text = "信箱:";
            // 
            // 信箱TextBox
            // 
            this.信箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "信箱", true));
            this.信箱TextBox.Location = new System.Drawing.Point(218, 211);
            this.信箱TextBox.Name = "信箱TextBox";
            this.信箱TextBox.Size = new System.Drawing.Size(276, 36);
            this.信箱TextBox.TabIndex = 5;
            // 
            // 薪資Label
            // 
            薪資Label.AutoSize = true;
            薪資Label.Location = new System.Drawing.Point(78, 274);
            薪資Label.Name = "薪資Label";
            薪資Label.Size = new System.Drawing.Size(64, 24);
            薪資Label.TabIndex = 6;
            薪資Label.Text = "薪資:";
            // 
            // 薪資TextBox
            // 
            this.薪資TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "薪資", true));
            this.薪資TextBox.Location = new System.Drawing.Point(218, 271);
            this.薪資TextBox.Name = "薪資TextBox";
            this.薪資TextBox.Size = new System.Drawing.Size(276, 36);
            this.薪資TextBox.TabIndex = 7;
            // 
            // 雇用日期Label
            // 
            雇用日期Label.AutoSize = true;
            雇用日期Label.Location = new System.Drawing.Point(78, 334);
            雇用日期Label.Name = "雇用日期Label";
            雇用日期Label.Size = new System.Drawing.Size(112, 24);
            雇用日期Label.TabIndex = 8;
            雇用日期Label.Text = "雇用日期:";
            // 
            // 雇用日期DateTimePicker
            // 
            this.雇用日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.員工BindingSource, "雇用日期", true));
            this.雇用日期DateTimePicker.Location = new System.Drawing.Point(218, 331);
            this.雇用日期DateTimePicker.Name = "雇用日期DateTimePicker";
            this.雇用日期DateTimePicker.Size = new System.Drawing.Size(200, 36);
            this.雇用日期DateTimePicker.TabIndex = 9;
            // 
            // 是否已婚Label
            // 
            是否已婚Label.AutoSize = true;
            是否已婚Label.Location = new System.Drawing.Point(78, 397);
            是否已婚Label.Name = "是否已婚Label";
            是否已婚Label.Size = new System.Drawing.Size(112, 24);
            是否已婚Label.TabIndex = 10;
            是否已婚Label.Text = "是否已婚:";
            // 
            // 是否已婚CheckBox
            // 
            this.是否已婚CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.員工BindingSource, "是否已婚", true));
            this.是否已婚CheckBox.Location = new System.Drawing.Point(218, 386);
            this.是否已婚CheckBox.Name = "是否已婚CheckBox";
            this.是否已婚CheckBox.Size = new System.Drawing.Size(228, 49);
            this.是否已婚CheckBox.TabIndex = 11;
            this.是否已婚CheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.瀏覽ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.更新到資料庫ToolStripMenuItem,
            this.結束ToolStripMenuItem,
            this.顯示記錄ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 38);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 瀏覽ToolStripMenuItem
            // 
            this.瀏覽ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.第一筆ToolStripMenuItem,
            this.上一筆ToolStripMenuItem,
            this.下一筆ToolStripMenuItem,
            this.最末筆ToolStripMenuItem});
            this.瀏覽ToolStripMenuItem.Name = "瀏覽ToolStripMenuItem";
            this.瀏覽ToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.瀏覽ToolStripMenuItem.Text = "瀏覽";
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 更新到資料庫ToolStripMenuItem
            // 
            this.更新到資料庫ToolStripMenuItem.Name = "更新到資料庫ToolStripMenuItem";
            this.更新到資料庫ToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.更新到資料庫ToolStripMenuItem.Text = "更新到資料庫";
            this.更新到資料庫ToolStripMenuItem.Click += new System.EventHandler(this.更新到資料庫ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(73, 38);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 顯示記錄ToolStripMenuItem
            // 
            this.顯示記錄ToolStripMenuItem.Name = "顯示記錄ToolStripMenuItem";
            this.顯示記錄ToolStripMenuItem.Size = new System.Drawing.Size(121, 34);
            this.顯示記錄ToolStripMenuItem.Text = "顯示記錄";
            // 
            // 第一筆ToolStripMenuItem
            // 
            this.第一筆ToolStripMenuItem.Name = "第一筆ToolStripMenuItem";
            this.第一筆ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.第一筆ToolStripMenuItem.Text = "第一筆";
            this.第一筆ToolStripMenuItem.Click += new System.EventHandler(this.第一筆ToolStripMenuItem_Click);
            // 
            // 上一筆ToolStripMenuItem
            // 
            this.上一筆ToolStripMenuItem.Name = "上一筆ToolStripMenuItem";
            this.上一筆ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.上一筆ToolStripMenuItem.Text = "上一筆";
            this.上一筆ToolStripMenuItem.Click += new System.EventHandler(this.上一筆ToolStripMenuItem_Click);
            // 
            // 下一筆ToolStripMenuItem
            // 
            this.下一筆ToolStripMenuItem.Name = "下一筆ToolStripMenuItem";
            this.下一筆ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.下一筆ToolStripMenuItem.Text = "下一筆";
            this.下一筆ToolStripMenuItem.Click += new System.EventHandler(this.下一筆ToolStripMenuItem_Click);
            // 
            // 最末筆ToolStripMenuItem
            // 
            this.最末筆ToolStripMenuItem.Name = "最末筆ToolStripMenuItem";
            this.最末筆ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.最末筆ToolStripMenuItem.Text = "最末筆";
            this.最末筆ToolStripMenuItem.Click += new System.EventHandler(this.最末筆ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 482);
            this.Controls.Add(員工編號Label);
            this.Controls.Add(this.員工編號TextBox);
            this.Controls.Add(姓名Label);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(信箱Label);
            this.Controls.Add(this.信箱TextBox);
            this.Controls.Add(薪資Label);
            this.Controls.Add(this.薪資TextBox);
            this.Controls.Add(雇用日期Label);
            this.Controls.Add(this.雇用日期DateTimePicker);
            this.Controls.Add(是否已婚Label);
            this.Controls.Add(this.是否已婚CheckBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 員工BindingSource;
        private Database1DataSetTableAdapters.員工TableAdapter 員工TableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox 員工編號TextBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.TextBox 信箱TextBox;
        private System.Windows.Forms.TextBox 薪資TextBox;
        private System.Windows.Forms.DateTimePicker 雇用日期DateTimePicker;
        private System.Windows.Forms.CheckBox 是否已婚CheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 瀏覽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 第一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最末筆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新到資料庫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顯示記錄ToolStripMenuItem;
    }
}

