using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Database1Entities db = new Database1Entities();
        //  ------   表單載入時執行   -------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = from p in db.產品
                         orderby p.編號 descending
                         select new { p.編號, p.品名, p.單價, p.數量 };
            dataGridView1.DataSource = result.ToList();
        }
        // ------  按下 [新增] 鈕執行  -----------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                產品 product = new 產品();
                product.編號 = txtId.Text;
                product.品名 = txtName.Text;
                product.單價 = int.Parse(txtPrice.Text);
                product.數量 = int.Parse(txtQty.Text);
                db.產品.Add(product);
                db.SaveChanges();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ------  按 [修改] 鈕執行   -----------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var product = (from p in db.產品
                               where p.編號 == txtId.Text
                               select p).Single();
                product.品名 = txtName.Text;
                product.單價 = int.Parse(txtPrice.Text);
                product.數量 = int.Parse(txtQty.Text);
                db.SaveChanges();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ------  按 [刪除] 鈕執行  -------------------------------
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var product = (from p in db.產品
                               where p.編號 == txtId.Text
                               select p).Single();
                db.產品.Remove(product);
                db.SaveChanges();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
