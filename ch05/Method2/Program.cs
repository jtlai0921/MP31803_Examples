using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        //呼叫CheckYear靜態方法，可判斷並顯示傳入的y年份是閏年還是平年
        static void CheckYear(int y)
        {
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine("\n=== {0} 年 為 閏年! ===", y);
            }
            else
            {
                Console.WriteLine("\n=== {0} 年 為 平年! ===", y);
            }
        }

        static void Main(string[] args)
        {
            int year;  //宣告year用來存年份
            Console.Write("請輸入年份:");
            //處理例外
            try
            {
                //由鍵盤輸入年份並傳成整數再指定給year整數變數
                year = int.Parse(Console.ReadLine());
                //呼叫CheckYear()方法，並傳入year參數
                CheckYear(year);
            }
            catch (Exception ex)   //若輸入字串，則會產生例外被catch補捉
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
