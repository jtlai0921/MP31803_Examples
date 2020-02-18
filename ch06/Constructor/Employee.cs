using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        public string EmpID { get; set; }      //EmpID 為編號屬性
        public string EmpName { get; set; }    //EmpName 為姓名屬性
        private int empSalary;   	           //_salary為私有欄位成員
        public int EmpSalary
        {
            get
            {
                return empSalary;
            }
            set
            {
                if (value < 22000)
                    value = 22000;  //若value小於22000,則指定value為22000
                empSalary = value;
                Console.WriteLine("== 薪資範圍檢查結果 : empSalary = {0}", empSalary); // 驗證是否有執行set區塊
            }
        }
        //Employee建構函式
        public Employee(string vID, string vName, int vSalary)
        {
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
        }

        public void ShowInfo()	        //定義ShowInfo方法用來顯示產品的編號,姓名,薪資
        {
            Console.WriteLine("編號：{0}", EmpID);
            Console.WriteLine("姓名：{0}", EmpName);
            Console.WriteLine("薪資：{0}元", EmpSalary);
            Console.WriteLine("============================");
        }
    }
}
