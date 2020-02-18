using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] flag_name = new string[16];
        int[] question = new int[16];
        int test_num, right_num; //test_num紀錄題號, right_num紀錄答對題數

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "國旗常識大考驗！";
            Button[] btn = new Button[] {btn1, btn2, btn3, btn4, btn5, btn6,
              btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16 };
            for (int i = 0; i < flag_name.Length; i++)
            {   //載入圖檔
                flag_name[i] = btn[i].Text;
                question[i] = i + 1;
                imgFlag.Images.Add(Image.FromFile(flag_name[i] + ".jpg"));
            }
            for (int i = 1; i <= btn.GetUpperBound(0); i++)
            {
                btn[i].Click += new EventHandler(btn1_Click);//共用Btn1_Click事件
            }
            btnNew_Click(sender, e);  //執行BtnNew_Click事件函式
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int j, k, t;
            Random rnd = new Random();
            for (int i = 1; i <= 12; i++) //任取兩個陣列元素作交換，共執行12次
            {
                do  //取0-15之間兩個不相同的亂數
                {
                    j = rnd.Next(16);
                    k = rnd.Next(16);
                } while (j == k);
                t = question[j];
                question[j] = question[k];
                question[k] = t;
            }
            test_num = 1; right_num = 0;  //設題號為1，答對0題
            picFlag.Image = imgFlag.Images[question[0] - 1];
            lblMsg.Text = "第 " + test_num + " 題";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnClick = (Button)sender;  //取得按下哪個國名按鈕
            if (btnClick.Text == flag_name[question[test_num - 1] - 1])
            {   //若按鈕的文字和答案相同
                lblMsg.Text = " 你答對了! ";
                right_num += 1;   //答對題數加1
            }
            else
                lblMsg.Text = " 你答錯了!答案是" + flag_name[question[test_num - 1] - 1];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            test_num += 1;       //題號加1
            if (test_num <= 16)  //若題號<= 16，就顯示下一題
            {
                lblMsg.Text = "第 " + test_num + " 題";
                picFlag.Image = imgFlag.Images[question[test_num - 1] - 1];
            }
            else   //否則，顯示答對幾題
                lblMsg.Text = " 你已經答完全部題目!共答對" + right_num + "題";
        }
    }
}
