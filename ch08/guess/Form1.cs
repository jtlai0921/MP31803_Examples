using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int no1, no2, win, loss;    // 共用變數，no1,no2存放亂數，win,loss存放輸贏次數

        private void Form1_Load(object sender, EventArgs e)
        {
            win = loss = 0;          //預設win,loss輸贏次數為0
            lblWin.Text = "贏 : " + win.ToString() + "次";
            lblLoss.Text = "輸 : " + loss.ToString() + "次";
            lblMsg.Text = "";
            btn1.Enabled = false;   // 按鈕1無效
            btn2.Enabled = false;   // 按鈕2無效
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "請選擇 按鈕1或按鈕2...";
            lblMsg.Text = "";
            btn1.Enabled = true;           // 按鈕1無效
            btn2.Enabled = true;           // 按鈕2無效      
            btnStart.Enabled = false;    // 開始鈕無效           
            btn1.Text = "按鈕1";           // 顯示按鈕1訊息
            btn2.Text = "按鈕2";           // 顯示按鈕2訊息
            Random ranobj = new Random();
            no1 = ranobj.Next(1, 100);    // 產生1~99的亂數       
            do
                no2 = ranobj.Next(1, 100);
            while (no1 == no2);             // 檢查亂數是否重複，若是重新產生
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(no1);   // 將no1亂數顯示在按鈕1上面
            btn2.Text = Convert.ToString(no2);   // 將no2亂數顯示在按鈕2上面
            if (no1 > no2)      //若no1 > no2
            {
                lblMsg.Text = "你猜對了!";
                win++;          // 贏的次數加1
            }
            else
            {
                lblMsg.Text = "你猜錯了!";
                loss++;        // 輸的次數加1
            }
            lblWin.Text = "贏 : " + win.ToString() + "次";
            lblLoss.Text = "輸 : " + loss.ToString() + "次";
            lblTitle.Text = "請按 開始鈕 猜哪個按鈕大";
            btnStart.Enabled = true;                                 // 開始鈕有效
            btn1.Enabled = false; btn2.Enabled = false;     // 按鈕1、2無效
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(no1);   // 將no1亂數顯示在按鈕1上面
            btn2.Text = Convert.ToString(no2);   // 將no2亂數顯示在按鈕2上面
            if (no2 > no1)  //若no2 > no1
            {
                lblMsg.Text = "你猜對了!"; win++;     // 贏的次數加1
            }
            else
            {
                lblMsg.Text = "你猜錯了!"; loss++;    // 輸的次數加1
            }
            lblWin.Text = "贏 : " + win.ToString() + "次";
            lblLoss.Text = "輸 : " + loss.ToString() + "次";
            lblTitle.Text = "請按 開始鈕 猜哪個按鈕大";
            btnStart.Enabled = true;                               // 開始鈕有效
            btn1.Enabled = false; btn2.Enabled = false;   // 按鈕1、2無效
        }
    }
}
