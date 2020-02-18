using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelationDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.訂貨明細' 資料表。您可以視需要進行移動或移除。
            this.訂貨明細TableAdapter.Fill(this.northwindDataSet.訂貨明細);
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.訂貨主檔' 資料表。您可以視需要進行移動或移除。
            this.訂貨主檔TableAdapter.Fill(this.northwindDataSet.訂貨主檔);
            訂貨主檔DataGridView.Dock = DockStyle.Top;  // 控制項駐停在表單上方
            訂貨明細DataGridView.Dock = DockStyle.Fill;	// 控制項填滿整個表單

        }
    }
}
