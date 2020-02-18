using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    //引用本命名空間,才能使用Form表單類別

namespace FirstForm
{
    class MyForm : Form                 //繼承System.Windows.Forms命名空間下的Form類別
    {
        Button btnOk;     //宣告btnOk為Button按鈕類別的物件
        public MyForm()
        {
            btnOk = new Button();         //建立btnOk按鈕物件
            btnOk.Text = "確定";          //設定btnOk按鈕上面的文字為"確定"  
            btnOk.Width = 60;             //設定btnOk按鈕的寛為60
            btnOk.Height = 30;            //設定btnOk按鈕的高為30
            btnOk.Visible = true;         //設定btnOk按鈕顯示
            btnOk.Left = 20;              //設定btnOk距離表單左上角的水平位置為20
            btnOk.Top = 15;               //設定btnOk距離表單左上角的垂直位置為15
            this.Width = 270;             //設定表單的寬度270
            this.Height = 100;            //設定表單的高度100
            this.Controls.Add(btnOk);     //在表單中加入一個btnOk按鈕(即確定鈕) 
            //表單的標題顯示"第一個視窗程式"
            this.Text = "第一個視窗應用程式";
            //指定btnOk按鈕的Click事件被觸發時會執行Click_Event事件
            //處理函式, 所以當按下btnOk按鈕時會執行Click_Event事件處理函式
            btnOk.Click += new EventHandler(Click_Event);
        }
        //Click_Event事件處理函式用來處理btnOk.Click事件
        private void Click_Event(System.Object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello World...\n歡迎光臨Windows Form視窗程式");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 231);
            this.Name = "MyForm";
            this.ResumeLayout(false);

        }
    }
}
