using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //設定開檔對話方塊的檔名篩選字串
            openFileDialog1.Filter = "Rich Text(*.rtf)|*.rtf|All files(*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = ".rtf";    //設定存檔時的預設副檔名為rtf
            rtbText.LoadFile("demo.rtf", RichTextBoxStreamType.RichText);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {   //若在開檔對話方塊按確定鈕，就開啟指定的檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                rtbText.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {   //若在存檔對話方塊按確定鈕，就儲存指定的檔案
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                rtbText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }

        private void mnuForeC_Click(object sender, EventArgs e)
        {   // 若在色彩對話方塊按確定鈕，就設定選取文字的前景色
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtbText.SelectionColor = colorDialog1.Color;
        }

        private void mnuBackC_Click(object sender, EventArgs e)
        {   // 若在色彩對話方塊按確定鈕，就設定選取文字的背景色
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtbText.SelectionBackColor = colorDialog1.Color;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {   // 若在字型對話方塊按確定鈕，就設定選取文字的字型
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                rtbText.SelectionFont = fontDialog1.Font;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
