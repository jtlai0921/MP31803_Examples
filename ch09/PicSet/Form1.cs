using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbLoad.Checked = true;  //預設為顯示圖檔
            rdbSize1.Checked = true;  //預設為原尺寸
        }

        private void rdbSize1_CheckedChanged(object sender, EventArgs e)
        {
            picShow.SizeMode = PictureBoxSizeMode.Normal;  //原尺寸
        }

        private void rdbSize2_CheckedChanged(object sender, EventArgs e)
        {
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;  //放大
        }

        private void rdbSize3_CheckedChanged(object sender, EventArgs e)
        {
            picShow.SizeMode = PictureBoxSizeMode.CenterImage;  //置中
        }

        private void rdbSize4_CheckedChanged(object sender, EventArgs e)
        {
            picShow.SizeMode = PictureBoxSizeMode.Zoom;  //等比例放大
        }

        private void rdbLoad_CheckedChanged(object sender, EventArgs e)
        {
            picShow.Image = new Bitmap("Cat.png");  //載入圖檔
        }

        private void rdbNull_CheckedChanged(object sender, EventArgs e)
        {
            picShow.Image = null;  //移除圖檔
        }
    }
}
