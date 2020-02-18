﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ------ 表單載入時執行  -------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.員工' 資料表。您可以視需要進行移動或移除。
            this.員工TableAdapter.Fill(this.database1DataSet.員工);

        }
        // ------   按 [更新] 功能項目執行  - ----------------------
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                員工BindingSource.EndEdit();          //結束編輯資料
                員工TableAdapter.Update(database1DataSet); //將資料寫回資料庫
                MessageBox.Show("資料更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
