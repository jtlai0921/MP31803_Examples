using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoads
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee anyone = new Employee();        //無引數之建構函式
            anyone.ShowInfo();
            Console.WriteLine("送審中的員工姓名更新後...");
            anyone.ShowInfo("D0005", "趙大樹", 25000);
            //使用建構函式建立物件時給予編號, 姓名, 薪資的初值
            Employee person1 = new Employee("A0011", "李夢秋", 35000);
            person1.ShowInfo();
            Console.Read();
        }
    }
}
