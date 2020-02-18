using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSetValue
{
    class Employee
    {
        public string EmpID { set; get; }
        public string EmpName { set; get; }
        public string EmpTel { set; get; }
        public string EmpAdd { set; get; }
        private int empSalary;		//empSalary薪資欄位
        public int EmpSalary        //EmpSalary薪資屬性須大於22000
        {
            get
            {
                return empSalary;
            }
            set
            {
                if (value < 22000) value = 22000;
                empSalary = value;
            }
        }
        //顯示員工資訊
        public void ShowInfo()
        {
            Console.WriteLine("編號：{0}", EmpID);
            Console.WriteLine("姓名：{0}", EmpName);
            Console.WriteLine("電話：{0}", EmpTel);
            Console.WriteLine("住址：{0}", EmpAdd);
            Console.WriteLine("薪資：{0}", EmpSalary.ToString());
            Console.WriteLine("===========================");
        }
    }
}
