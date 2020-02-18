using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Employee
    {
        public string empID, empName;
        private int empSalary;     //empSalary為私有欄位成員
        public int EmpSalary       // 公開屬性成員
        {
            get
            {
                return empSalary;
            }
            set
            {
                if (value < 22000)
                    value = 22000;   //若value小於22000,則指定value為22000
                empSalary = value;
                Console.WriteLine("==== 薪資範圍檢查結果 : empSalary = {0}", empSalary);
            }
        }
        public void ShowInfo()	        //定義ShowInfo方法用來顯示產品的編號,姓名,薪資
        {
            Console.WriteLine("編號：{0}", empID);
            Console.WriteLine("姓名：{0}", empName);
            Console.WriteLine("薪資：{0}元", empSalary);
            Console.WriteLine("============================");
        }
    }
}
