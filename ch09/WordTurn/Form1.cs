using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTurn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;  //成員變數n記錄目前圖檔索引
        bool turnR = true;  //成員變數turnR記綠目前是正反轉,預設是正轉
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 480; Height = 320;  //指定表單的大小
            FormBorderStyle = FormBorderStyle.Fixed3D;  //設表單不能調整大小
            MaximizeBox = false;  //設表單不能最大化
            BackgroundImageLayout = ImageLayout.Zoom;  //設背景自動縮放
            BackgroundImage = new Bitmap("background.jpg");  //載入背景圖
            DoubleBuffered = true;  //開啟雙重緩衝
            pictureBox1.BackColor = Color.Transparent;  //設背景色為透明
            pictureBox1.Image = imageList1.Images[n];  //顯示第一張圖
            timer1.Interval = 100;  //設計時器間隔
            timer1.Enabled = true;  //啟動計時器
            btnR.Enabled = false;  //正轉鈕無法點選
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (turnR == true)  //如為正轉
            {
                n++;
                if (n >= imageList1.Images.Count)  //假如索引值大於等於圖檔數量
                    n = 0;
            }
            else  //如為反轉
            {
                n--;
                if (n < 0)
                    n = 18;
            }
            pictureBox1.Image = imageList1.Images[n];  //顯示第n圖
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            btnL.Enabled = true;
            turnR = true;  //設為正轉
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnR.Enabled = true;
            btnL.Enabled = false;  //
            turnR = false;  //設為反轉
        }
    }
}
