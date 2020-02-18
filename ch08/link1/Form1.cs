using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace link1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "小算盤是很受歡迎的電腦應用程式\n請按下列超連結來認識！";
            lblTitle.Font = new Font("標楷體", 12, FontStyle.Bold);
        }
        //  -----  按 [小算盤簡介] 連結標籤執行
        private void llblReadMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("小算盤.txt");
        }
        //  ----  按 [小算盤] 連結標籤執行
        private void llblapp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\calc.exe");
        }
        //  ----  接 [使用方法] 連結標籤執行
        private void llblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start
               ("https://support.microsoft.com/zh-tw/help/4026389/windows-calculator-in-windows-10");
        }
    }
}
