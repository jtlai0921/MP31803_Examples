using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabbit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;  //紀錄是否可拖曳，預設為不可
        int x_down, y_down; //紀錄滑鼠按下時的座標值

        private void Form1_Load(object sender, EventArgs e)
        {
            imgHat.Images.Add(Image.FromFile("hat1.gif"));//載入圖檔
            imgHat.Images.Add(Image.FromFile("hat2.gif"));
            picHat.Image = imgHat.Images[0];  //預設為第1張圖
        }
        //滑鼠移入時
        private void picHat_MouseEnter(object sender, EventArgs e)
        {
            picHat.Image = imgHat.Images[1];  //改為第2張圖
        }
        //滑鼠離開時
        private void picHat_MouseLeave(object sender, EventArgs e)
        {
            picHat.Image = imgHat.Images[0];  //改為第1張圖
        }
        //按下滑鼠左鍵時
        private void picHat_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;    //設為可以拖曳
            x_down = e.X;   //紀錄滑鼠的X座標
            y_down = e.Y;   //紀錄滑鼠的Y座標
        }
        //滑鼠移動時
        private void picHat_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)   //若drag值為true
            {
                picHat.Left += (e.X - x_down); //改變圖檔的X座標
                picHat.Top += (e.Y - y_down);  //改變圖檔的Y座標
            }
        }

        //放開滑鼠左鍵時
        private void picHat_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;    //設為不可以拖曳
            picHat.Image = imgHat.Images[0];  //改為第1張圖
        }
    }
}
