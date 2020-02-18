using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int price1 = 0; //記錄電腦的價格
        int price2 = 0; //記錄配件的價格

        private void Form1_Load(object sender, EventArgs e)
        {
            lblType.Text = "";     //預設標籤為空白
            lblAdd.Text = ""; lblTotal.Text = "";
            mnuType.DropDown = this.contextMenuStrip1;  //設定機型的下拉式清單的項目來源為contextMenuStrip1
            mnuAdd.DropDown = this.contextMenuStrip2;  //設定配件的下拉式清單的項目來源為contextMenuStrip2
            cmnuNB.Click += cmnuPC_Click; //設定共用事件
            cmnuPAD.Click += cmnuPC_Click;
            lblType.ContextMenuStrip = contextMenuStrip1;   //指定標籤的快顯功能表來源
            lblAdd.ContextMenuStrip = contextMenuStrip2;
        }

        private void cmnuPC_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;  //取得觸發事件的物件
            if (mnu.Equals(cmnuPC))    //若是cmnuPC
                price1 = 20000;
            else if (mnu.Equals(cmnuNB))//若是cmnuNB
                price1 = 30000;
            else    //其他即cmnuPAD
                price1 = 25000;
            lblType.Text = mnu.Text + price1.ToString() + "元";  //顯示電腦價格            
            lblTotal.Text = (price1 + price2).ToString() + "元"; //顯示總價
        }

        private void cmnuHD_Click(object sender, EventArgs e)
        {
            cmnuHD.Checked = !cmnuHD.Checked; //改變cmnuHD的勾選狀態
            check();    //呼叫check方法
        }

        private void cmnuAP_Click(object sender, EventArgs e)
        {
            cmnuAP.Checked = !cmnuAP.Checked;
            check();
        }

        private void cmnuCD_Click(object sender, EventArgs e)
        {
            cmnuCD.Checked = !cmnuCD.Checked;
            check();
        }

        private void check()
        {
            lblAdd.Text = "";
            price2 = 0;
            if (cmnuHD.Checked == true)  //若勾選cmnuHD
            {   //顯示勾選配件的名稱和價格
                lblAdd.Text += cmnuHD.Text + "1499元 , ";
                price2 += 1499; //加上配件價格
            }
            if (cmnuAP.Checked == true)  //若勾選cmnuAP
            {
                lblAdd.Text += cmnuAP.Text + "399元 , ";
                price2 += 399;
            }
            if (cmnuCD.Checked == true)  //若勾選cmnuCD
            {
                lblAdd.Text += cmnuCD.Text + "999元";
                price2 += 999;
            }
            lblTotal.Text = (price1 + price2).ToString() + "元";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
