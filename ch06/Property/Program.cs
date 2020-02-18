using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1;               //宣告person1物件屬於Employee類別
            person1 = new Employee();       //建立person1物件
            person1.empID = "A0011";      	//設定編號欄位
            person1.empName = "李夢秋"; 	//設定姓名欄位
            person1.EmpSalary = 35000;  	//設定薪資欄位
            person1.ShowInfo();

            Employee person2 = new Employee();   //宣告並建立person2物件
            person2.empID = "B0107";
            person2.empName = "劉德仁";
            person2.EmpSalary = 19000;           //設定EmpSalary屬性值
            person2.ShowInfo();

            Console.Read();
        }
    }
}
