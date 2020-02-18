using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Employee       //定義Employee類別
    {
        //宣告public公開型的empID編號, empName姓名欄位
        public string empID, empName;
        public int empSalary;  		//宣告public公開型的empSalary薪資欄位
        public void ShowInfo()	    //定義ShowInfo方法用來顯示產品的編號,姓名,薪資
        {
            Console.WriteLine("編號：{0}", empID);
            Console.WriteLine("姓名：{0}", empName);
            Console.WriteLine("薪資：{0}元", empSalary);
            Console.WriteLine("============================");
        }
    }
}
