using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1;           //宣告person1物件屬於Employee類別
            person1 = new Employee();   //建立person1物件
            person1.empID = "A0011";    //設定eEmpID編號欄位
            person1.empName = "李夢秋";	//設定empName姓名欄位
            person1.empSalary = 35000;  //設定empSalay薪資欄位
            person1.ShowInfo();

            Employee person2 = new Employee();   //宣告並建立person2物件
            person2.empID = "B0107";
            person2.empName = "劉德仁";
            person2.empSalary = 19000;
            person2.ShowInfo();

            Console.Read();
        }
    }
}
