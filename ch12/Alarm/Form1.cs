using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int setSec; //紀錄設定的秒數
        int sec;    //倒數的秒數

        private void Form1_Load(object sender, EventArgs e)
        {
            setSec = 10;    //預設設定秒數為10
            sec = setSec;   //預設倒數秒數為設定秒數
            ttxtSecond.Text = setSec.ToString();//預設設定秒數
            tcboSet.SelectedIndex = 0;          //預設為灰底
            lblSecond.Text = sec.ToString();    //顯示倒數秒數   
            slblMsg.Text = "設定";              //預設訊息
            spgbSecond.Maximum = setSec;        //設進度棒的最大值為設定秒數
            tmrRun.Interval = 1000;             //每秒觸發計時器一次
        }

        private void tbtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblSecond.Text == "0")   //若倒數秒數為0
                {
                    setSec = int.Parse(ttxtSecond.Text); //指定設定秒數
                    sec = setSec;   //指定倒數秒數
                    lblSecond.Text = setSec.ToString(); //顯示倒數秒數
                    spgbSecond.Maximum = setSec;        //設進度棒的最大值為設定秒數
                    spgbSecond.Value = 0;               //設進度棒的值為0
                }
                tmrRun.Start();                 //啟動計時器
                slblMsg.Text = "開始";          //顯示訊息
                ttxtSecond.Enabled = false;     //文字方塊不能使用
            }
            catch
            {
                ttxtSecond.Text = "10";
                slblMsg.Text = "錯誤";
            }
        }

        private void tmrRun_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;  //倒數秒數減1
            lblSecond.Text = sec.ToString();    //顯示倒數秒數
            spgbSecond.Value = setSec - sec;    //設進度棒值為setSec - sec
            if (sec == 0)   //若倒數秒數為0
            {
                tmrRun.Stop();  //停止計時器
                slblMsg.Text = "結束";
                ttxtSecond.Enabled = true;  //文字方塊可以使用
            }
        }

        private void tbtnPause_Click(object sender, EventArgs e)
        {
            tmrRun.Stop();  //停止計時器
            slblMsg.Text = "暫停";
        }

        private void tcboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcboSet.SelectedIndex)
            {
                case 0:
                    lblSecond.ForeColor = Color.Black;
                    lblSecond.BackColor = Color.Gray; break;
                case 1:
                    lblSecond.ForeColor = Color.LightGreen;
                    lblSecond.BackColor = Color.Black; break;
                case 2:
                    lblSecond.ForeColor = Color.Blue;
                    lblSecond.BackColor = Color.White; break;
            }
        }
    }
}
