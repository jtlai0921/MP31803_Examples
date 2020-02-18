using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mcnVacation.Enabled = false;  	// 預設mcnVacation不啟用
            mcnVacation.MinDate = DateTime.Now;
            dtpWork.MaxDate = DateTime.Now;
        }

        private void dtpWork_ValueChanged(object sender, EventArgs e)
        {
            int years = (DateTime.Now - dtpWork.Value).Days / 365;	//年資
            int vacation_days = 0;     // 預設可休假天數=0
            if (years < 1)  //如果年資少於1年
            {
                mcnVacation.Enabled = false;    // mcnVacation不啟用
                lblMsg.Text = "你的任職年資未滿1年，連休日期為0天！";
                lblVacation.Text = "請繼續努力！";
            }
            else    //如果年資大於1年
            {
                if (years > 5)  //如果年資大於5年
                    vacation_days = 5;  // 可休假天數=5
                else
                    vacation_days = 3;  // 可休假天數=3
                mcnVacation.Enabled = true; // mcnVacation啟用
                mcnVacation.MaxSelectionCount = vacation_days;  //設可選取天數
                lblMsg.Text = "你的任職年資為" + years + "年，請選擇 "
                    + vacation_days + "天連休日期：";
            }
        }

        private void mcnVacation_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblVacation.Text = "休假日由\n" + mcnVacation.SelectionStart.ToShortDateString()
                  + "\n到\n" + mcnVacation.SelectionEnd.ToShortDateString();
        }
    }
}
