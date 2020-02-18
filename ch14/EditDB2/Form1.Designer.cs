namespace EditDB2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new EditDB2.Database1DataSet();
            this.員工BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.員工TableAdapter = new EditDB2.Database1DataSetTableAdapters.員工TableAdapter();
            this.tableAdapterManager = new EditDB2.Database1DataSetTableAdapters.TableAdapterManager();
            this.員工編號TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.信箱TextBox = new System.Windows.Forms.TextBox();
            this.薪資TextBox = new System.Windows.Forms.TextBox();
            this.雇用日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.是否已婚CheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            員工編號Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            信箱Label = new System.Windows.Forms.Label();
            薪資Label = new System.Windows.Forms.Label();
            雇用日期Label = new System.Windows.Forms.Label();
            是否已婚Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = EditDB2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.員工TableAdapter = this.員工TableAdapter;
            // 
            // 員工編號Label
            // 
            員工編號Label.AutoSize = true;
            員工編號Label.Location = new System.Drawing.Point(88, 102);
            員工編號Label.Name = "員工編號Label";
            員工編號Label.Size = new System.Drawing.Size(112, 24);
            員工編號Label.TabIndex = 0;
            員工編號Label.Text = "員工編號:";
            // 
            // 員工編號TextBox
            // 
            this.員工編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "員工編號", true));
            this.員工編號TextBox.Location = new System.Drawing.Point(227, 99);
            this.員工編號TextBox.Name = "員工編號TextBox";
            this.員工編號TextBox.Size = new System.Drawing.Size(200, 36);
            this.員工編號TextBox.TabIndex = 1;
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(88, 162);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(64, 24);
            姓名Label.TabIndex = 2;
            姓名Label.Text = "姓名:";
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(227, 159);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(200, 36);
            this.姓名TextBox.TabIndex = 3;
            // 
            // 信箱Label
            // 
            信箱Label.AutoSize = true;
            信箱Label.Location = new System.Drawing.Point(88, 222);
            信箱Label.Name = "信箱Label";
            信箱Label.Size = new System.Drawing.Size(64, 24);
            信箱Label.TabIndex = 4;
            信箱Label.Text = "信箱:";
            // 
            // 信箱TextBox
            // 
            this.信箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "信箱", true));
            this.信箱TextBox.Location = new System.Drawing.Point(227, 219);
            this.信箱TextBox.Name = "信箱TextBox";
            this.信箱TextBox.Size = new System.Drawing.Size(200, 36);
            this.信箱TextBox.TabIndex = 5;
            // 
            // 薪資Label
            // 
            薪資Label.AutoSize = true;
            薪資Label.Location = new System.Drawing.Point(88, 282);
            薪資Label.Name = "薪資Label";
            薪資Label.Size = new System.Drawing.Size(64, 24);
            薪資Label.TabIndex = 6;
            薪資Label.Text = "薪資:";
            // 
            // 薪資TextBox
            // 
            this.薪資TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.員工BindingSource, "薪資", true));
            this.薪資TextBox.Location = new System.Drawing.Point(227, 279);
            this.薪資TextBox.Name = "薪資TextBox";
            this.薪資TextBox.Size = new System.Drawing.Size(200, 36);
            this.薪資TextBox.TabIndex = 7;
            // 
            // 雇用日期Label
            // 
            雇用日期Label.AutoSize = true;
            雇用日期Label.Location = new System.Drawing.Point(88, 342);
            雇用日期Label.Name = "雇用日期Label";
            雇用日期Label.Size = new System.Drawing.Size(112, 24);
            雇用日期Label.TabIndex = 8;
            雇用日期Label.Text = "雇用日期:";
            // 
            // 雇用日期DateTimePicker
            // 
            this.雇用日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.員工BindingSource, "雇用日期", true));
            this.雇用日期DateTimePicker.Location = new System.Drawing.Point(227, 339);
            this.雇用日期DateTimePicker.Name = "雇用日期DateTimePicker";
            this.雇用日期DateTimePicker.Size = new System.Drawing.Size(200, 36);
            this.雇用日期DateTimePicker.TabIndex = 9;
            // 
            // 是否已婚Label
            // 
            是否已婚Label.AutoSize = true;
            是否已婚Label.Location = new System.Drawing.Point(88, 407);
            是否已婚Label.Name = "是否已婚Label";
            是否已婚Label.Size = new System.Drawing.Size(112, 24);
            是否已婚Label.TabIndex = 10;
            是否已婚Label.Text = "是否已婚:";
            // 
            // 是否已婚CheckBox
            // 
            this.是否已婚CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.員工BindingSource, "是否已婚", true));
            this.是否已婚CheckBox.Location = new System.Drawing.Point(227, 399);
            this.是否已婚CheckBox.Name = "是否已婚CheckBox";
            this.是否已婚CheckBox.Size = new System.Drawing.Size(218, 42);
            this.是否已婚CheckBox.TabIndex = 11;
            this.是否已婚CheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.員工BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(790, 39);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 36);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 36);
            this.toolStripButton1.Text = "更新";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 493);
            this.Controls.Add(this.bindingNavigator1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.員工BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

