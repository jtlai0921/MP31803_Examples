using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sec = 0;  //欄位成員變數sec記錄總秒數，各函式彼此共用
        private void Form1_Load(object sender, EventArgs e)
        {
            lblSec.BackColor = Color.Black;  //背景為黑色
            lblSec.ForeColor = Color.LightGreen;  //字為亮綠色
            lblSec.TextAlign = ContentAlignment.MiddleCenter;  //文字置中
            lblSec.Text = string.Format("{0:000.0 秒}", sec);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sec = 0;  //秒數歸零
            timer1.Enabled = true;  //啟動計時器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSec.Text = string.Format("{0:000.0 秒}", sec += 0.1);  //秒數加0.1
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;  //關閉計時器
        }
    }
}
