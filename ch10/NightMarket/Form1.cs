using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] market = new string[] { "基隆廟口", "台北士林", "台中逢甲", "台南小北街", "高雄六合" };
        string[][] food = new string[5][];

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMarket.Items.AddRange(market);
            food[0] = new string[] { "鼎邊銼", "泡泡冰" };
            food[1] = new string[] { "花枝羹", "大餅包小餅", "蚵仔煎" };
            food[2] = new string[] { "大腸包小腸", "章魚燒" };
            food[3] = new string[] { "棺材板", "鱔魚意麵", "土魠魚羹", "蝦捲" };
            food[4] = new string[] { "滷味", "木瓜牛奶" };
            cboMarket.SelectedIndex = 0;
        }

        private void cboMarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFood.Items.Clear();
            lstFood.Items.AddRange(food[cboMarket.SelectedIndex]);
        }
    }
}
