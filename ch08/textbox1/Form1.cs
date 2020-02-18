using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 圓半徑文字方塊內資料有異動時執行
        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            //使用try{…}框住計算圓周長和圓面積的程式碼
            try
            {
                double r = double.Parse(txtRadius.Text);
                txtLen.Text = (2 * r * 3.14).ToString();
                txtArea.Text = (r * r * 3.14).ToString();
            }
            catch (Exception ex)
            { }
        }
    }
}
