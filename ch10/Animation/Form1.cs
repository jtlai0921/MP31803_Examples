using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBird.Image = Image.FromFile("bird.gif");
            tkbSpeed.Minimum = 1; tkbSpeed.Value = 5;      //設滑動桿初值
            lblSpeed.Text = "速度=" + tkbSpeed.Value.ToString();
            hsbWidth.Minimum = 10; hsbWidth.Value = 50;    //設水平捲軸初值
            lblWidth.Text = "寬度=" + hsbWidth.Value.ToString();
            vsbHeight.Minimum = 10; vsbHeight.Value = 50;  //設垂直捲軸初值
            lblHeight.Text = "高度=" + vsbHeight.Value.ToString();
            tmrRun.Enabled = true;  //啟動計時器
        }

        private void tmrRun_Tick(object sender, EventArgs e)
        {
            picBird.Left -= tkbSpeed.Value;  //圖檔左移tkbSpeed的Value值
            if (picBird.Left <= 0)           //圖檔超出左界就從右再出現
                picBird.Left = this.Width;
        }

        private void hsbWidth_Scroll(object sender, ScrollEventArgs e)
        {
            picBird.Width = hsbWidth.Value; //設圖檔寬度等於hsbWidth的Value值
            lblWidth.Text = "寬度=" + hsbWidth.Value.ToString();
        }

        private void vsbHeight_Scroll(object sender, ScrollEventArgs e)
        {
            picBird.Height = vsbHeight.Value; //設圖檔高度等於vsbHeight的Value值
            lblHeight.Text = "高度=" + vsbHeight.Value.ToString();
        }

        private void tkbSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "速度=" + tkbSpeed.Value.ToString();
        }
    }
}
