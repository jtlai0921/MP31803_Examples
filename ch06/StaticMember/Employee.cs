using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Employee
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        private int empSalary;   	         //empSalary為私有欄位成員       
        public int EmpSalary
        {
            get
            { return empSalary; }
            set
            {
                if (value < 22000)
                    value = 22000;   //若value小於22000,則指定value為22000
                empSalary = value;
            }
        }
        // -----------------------------------------------------------
        private static int num;       //num為私有靜態成員用來記錄共建幾個物件
        public static int Num          //欄位變屬性
        {
            get { return num; }       //唯讀屬性
        }
        // -----------------------------------------------------------
        public static void ShowNum()   //定義的方法成員
        {
            Console.WriteLine("目前共建立 {0} 位員工資料 !!\n", num);
        }

        // --------------------------------------------------------------- 
        public void ShowInfo()   //無引數的ShowInfo()方法多載, 可顯示員工資訊
        {
            Console.WriteLine("編號：{0}", EmpID);
            Console.WriteLine("姓名：{0}", EmpName);
            Console.WriteLine("薪資：{0}元", EmpSalary);
            Console.WriteLine("============================");
        }
        // -------有引數的ShowInfo()方法多載, 可設定及顯示員工的編號, 姓名, 薪資資訊
        public void ShowInfo(string vID, string vName, int vSalary)
        {
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
            ShowInfo();              //呼叫Employee類別的ShowInfo()方法
        }
        // -----------------------------------------------------------
        public Employee()   //無引數的Employee建構函式
        {
            num += 1;
            EmpID = "送審中";
            EmpName = "姓名未知";
            EmpSalary = 0;
        }
        // --------------------------------------------------------------- 
        public Employee(string vID, string vName, int vSalary) //有引數的Employee建構函式
        {
            num += 1;
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
        }
    }
}
