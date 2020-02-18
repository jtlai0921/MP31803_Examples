using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee
            {
                EmpID = "A0011",
                EmpName = "李夢秋",
                EmpAdd = "台中市中山路一段1號",
                EmpTel = "04-27895642",
                EmpSalary = 35000
            };
            Employee person2 = new Employee
            {
                EmpID = "B0107",
                EmpName = "劉德仁",
                EmpAdd = "台北市南港路一段2號",
                EmpTel = "02-21234567",
                EmpSalary = 16000
            };
            person1.ShowInfo();   //顯示員工資訊
            person2.ShowInfo();
            Console.Read();
        }
    }
}
