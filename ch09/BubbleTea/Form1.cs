using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            rdbTea1.Checked = true;
            rdbSizeL.Checked = true;
        }

        private void btbOK_Click(object sender, EventArgs e)
        {
            string msg = "";  //設訊息為空字串
            int price = 0;  //設總價為0元
            if(rdbSizeS.Checked == true)  //若選擇小杯
            {
                msg = "小杯";  //設訊息為小杯
                price = 25;    //設總價為25
            }
            else
            {
                msg = "大杯";  //設訊息為大杯
                price = 30;    //設總價為30
            }
            if (rdbTea1.Checked == true)  //若選rdbTea1
                msg += rdbTea1.Text;  //訊息加rdbTea1文字
            else if (rdbTea2.Checked == true) //若選rdbTea2
                msg += rdbTea2.Text;  //訊息加rdbTea2文字
            else
                msg += rdbTea3.Text;  //否則訊息加rdbTea3文字
            if (chk1.Checked == true)
                msg += chk1.Text;  //若勾選chk1就訊息加chk1文字
            if (chk2.Checked == true) //若勾選chk2
            {
                msg += chk2.Text;  //訊息加chk2文字
                price += 2;    //總價加2
            }
            if (chk3.Checked == true)  //若勾選chkAdd3
            {
                msg += chk3.Text; price -= 2;  //總價減2
            }
            lblPrice.Text = msg + price.ToString() + "元";//顯示訊息和總價
        }
    }
}
