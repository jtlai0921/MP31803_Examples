using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditDB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 定義RecordData()方法用來顯示目前記錄的位置
        void RecordData()
        {
            顯示記錄ToolStripMenuItem.Text = "第" +
            (員工BindingSource.Position + 1).ToString() + "第, 共" +
            員工BindingSource.Count.ToString() + "筆";
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.員工' 資料表。您可以視需要進行移動或移除。
            this.員工TableAdapter.Fill(this.database1DataSet.員工);
            RecordData();
        }

        private void 第一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            員工BindingSource.MoveFirst();
            RecordData();

        }

        private void 上一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            員工BindingSource.MovePrevious();
            RecordData();

        }

        private void 下一筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            員工BindingSource.MoveNext();
            RecordData();

        }

        private void 最末筆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            員工BindingSource.MoveLast();
            RecordData();

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                員工BindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            員工BindingSource.RemoveAt(員工BindingSource.Position);
        }

        private void 更新到資料庫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                員工BindingSource.EndEdit();
                員工TableAdapter.Update(database1DataSet);
                MessageBox.Show("資料更新成功");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
