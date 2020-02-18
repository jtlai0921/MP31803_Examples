using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Employee
    {
        private static int num;	//num為私有的靜態成員，用來記錄共產生幾個物件
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        private int empSalary;           	//empSalary為私有欄位成員
        public int EmpSalary
        {
            get
            { return empSalary; }
            set
            {
                if (value < 22000)
                    value = 22000;      //若value小於22000,則指定value為22000
                empSalary = value;
            }
        }

        //顯示共建立幾個員工記錄的靜態方法成員
        public static void ShowNum()
        {
            Console.WriteLine("目前共建立 {0} 個員工記錄!!\n", num);
        }

        //無引數的Employee建構函式
        public Employee()
        {
            num += 1;      //物件數量累加1
        }

        //此ShowInfo()多載方法可顯示員工資訊
        public void ShowInfo()
        {
            Console.WriteLine("編號：{0}", EmpID);
            Console.WriteLine("姓名：{0}", EmpName);
            Console.WriteLine("薪資：{0}元", EmpSalary);
            Console.WriteLine("============================");
        }
    }
}
