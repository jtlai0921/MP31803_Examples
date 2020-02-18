using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstForm
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm f = new MyForm();   	//使用MyForm類別建立f物件
            f.ShowDialog();		                //使用ShowDialog()方法顯示視窗
        }
    }
}
