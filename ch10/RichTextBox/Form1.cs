using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fSize;      //宣告fSize用來存放字型大小
        string fName;   //宣告fName用來存放字型名稱

        private void Form1_Load(object sender, EventArgs e)
        {
            fSize = 10; //預設字型大小為10
            fName = "新細明體"; //預設字型名稱
            rtbText.Font = new Font(fName, fSize);
        }
        //選取ForeColor下拉式清單時重設選取字串的前景色
        private void cboForeColor_SelectedIndexChanged(object sender, EventArgs e)
        {   //根據cboForeColor選項的索引值設定選取字串的前景色
            switch (cboForeColor.SelectedIndex)
            {
                case 0:
                    rtbText.SelectionColor = Color.Black; break;
                case 1:
                    rtbText.SelectionColor = Color.Red; break;
                case 2:
                    rtbText.SelectionColor = Color.Green; break;
                case 3:
                    rtbText.SelectionColor = Color.Blue; break;
            }
        }
        //選取cboBgColor下拉式清單時重設選取字串的背景色
        private void cboBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBgColor.SelectedIndex)
            {
                case 0:
                    rtbText.SelectionBackColor = Color.White; break;
                case 1:
                    rtbText.SelectionBackColor = Color.LightPink; break;
                case 2:
                    rtbText.SelectionBackColor = Color.LightGreen; break;
                case 3:
                    rtbText.SelectionBackColor = Color.LightBlue; break;
            }
        }
        //選取cboSize下拉式清單時重設字型大小
        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fSize = Convert.ToInt32(cboSize.Text);
            rtbText.SelectionFont = new Font(fName, fSize);
        }
        //選取cboFont下拉式清單時重設字型名稱
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fName = cboFont.Text;
            rtbText.SelectionFont = new Font(fName, fSize);
        }
        //按開檔鈕將MyFile.rtf檔的內容載入rtbText控制項的Text屬性內
        private void btnOpen_Click(object sender, EventArgs e)
        {
            rtbText.LoadFile("MyFile.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("開檔成功!!");
        }
        //按存檔鈕將rtbText的內容存入MyFile.rtf檔
        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbText.SaveFile("MyFile.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("存檔成功!!");
        }
        //按btnClear鈕時將選取的文字清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbText.SelectedText = "";  //清除選取的文字
        }
    }
}
