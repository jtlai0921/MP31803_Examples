using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Database1Entities db = new Database1Entities();
        // ------ 表單載入時執行此事件處理函式  -----------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            var result1 = from p in db.員工
                          select p;
            dataGridView1.DataSource = result1.ToList();

            var result2 = from p in db.員工
                          select p.薪資;  //查詢薪資欄位
            lblShow.Text = "最高薪資：" + result2.Max().ToString() +
                   "\n最低薪資：" + result2.Min().ToString() +
                   "\n平均薪資：" + result2.Average().ToString() +
                   "\n薪資加總：" + result2.Sum().ToString();
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.BackColor = Color.Pink;

        }

        // ------  按員工編號鈕執行此事件處理函式  ----------------------
        private void btnEmpId_Click(object sender, EventArgs e)
        {
            var result = from p in db.員工
                         orderby p.員工編號 ascending
                         select p;
            dataGridView1.DataSource = result.ToList();
        }

        // ------  按薪資鈕執行此事件處理函式  ---------------------------
        private void btnSalary_Click(object sender, EventArgs e)
        {
            var result = from p in db.員工
                         orderby p.薪資 ascending
                         select p;
            dataGridView1.DataSource = result.ToList();
        }

        // ------   按雇用日期鈕執行此事件處理函式  ------------------------
        private void btnDate_Click(object sender, EventArgs e)
        {
            var result = from p in db.員工
                         orderby p.雇用日期 ascending
                         select p;
            dataGridView1.DataSource = result.ToList();
        }

        // ------ 按單筆查詢鈕執行此事件處理函式  ------------------------
        private void btnSelEmpById_Click(object sender, EventArgs e)
        {
            var result = from p in db.員工
                         where p.員工編號 == txtEmpId.Text
                         select p;
            if (result.Count() == 0)
            {
                MessageBox.Show("沒有此員工");
                return;
            }
            foreach (var p in result)
            {
                MessageBox.Show("編號：" + p.員工編號 + "\n姓名：" + p.姓名 +
                                   "\n信箱：" + p.信箱 + "\n薪資：" + p.薪資);
            }
        }
    }
}
