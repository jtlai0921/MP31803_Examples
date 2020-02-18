using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;  //設ch為輸入的字元
            if ((ch < '0' || ch > '9') && (ch != '\b')) //判斷是否輸入是數字、倒退鍵
            {
                if ((byte)ch == 13)   //按Enter鍵控制權跳到btnOK按鈕
                {
                    btnOK.Focus();
                }
                else
                {
                    e.Handled = true;   //使輸入的字元清除且插入點游標停在原處
                    MessageBox.Show("請輸入數字", "錯誤 !!");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNum.Text + "的平方根為：" + Math.Sqrt(int.Parse(txtNum.Text)).ToString(), "平方根");
            txtNum.Text = "";  //txtNum內文字清成空白
            txtNum.Focus();    //控制權跳到txtNum
        }
    }
}
