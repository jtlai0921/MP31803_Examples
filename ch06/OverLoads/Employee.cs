using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoads
{
    class Employee
    {
        public string EmpID { get; set; }      //EmpID 為編號屬性
        public string EmpName { get; set; }    //EmpName 為姓名屬性
        private int empSalary;    //私有欄位成員
        public int EmpSalary       //將私有共用欄位改屬性，並作薪資範為檢查
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
                Console.WriteLine("==薪資檢查結果 : empSalary= {0}", empSalary);
            }
        }
        // 預設建構式
        public Employee()
        {
            EmpID = "送審中";
            EmpName = "姓名未知";
            EmpSalary = 0;        //自動執行薪資範圍檢查
        }
        // 三個引數的建構式
        public Employee(string vID, string vName, int vSalary)
        {
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;  //自動執行薪資範圍檢查
        }

        //ShowInfo()多載方法1-無引數僅可顯示員工資訊
        public void ShowInfo()
        {
            Console.WriteLine("編號：{0}", EmpID);
            Console.WriteLine("姓名：{0}", EmpName);
            Console.WriteLine("薪資：{0}元", EmpSalary);
            Console.WriteLine("============================");
        }
        //ShowInfo()多載方法2-有引數可設定員工編號, 姓名, 薪資並顯示員工資訊
        public void ShowInfo(string vID, string vName, int vSalary)
        {
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
            ShowInfo();              //呼叫Employee類別的ShowInfo()方法
        }
    }
}
