using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        //宣告靜態成員變數PI(即靜態欄位)
        private static double PI = 3.1416;     //PI為圓周率

        //Compute靜態方法可算出圓的體積
        static double Compute(double r)
        {
            // 靜態方法才能使用靜態變數
            return (4.0 / 3.0 * PI * r * r * r);      //傳回球體積
        }

        static void Main(string[] args)
        {
            double volume, radius;
            Console.Write(" 請輸入球半徑(公分) : ");
            radius = double.Parse(Console.ReadLine());
            //呼叫Compute靜態方法並傳入半徑，最後再將結果傳回給volume
            volume = Compute(radius);
            Console.WriteLine();
            Console.WriteLine(" 球半徑 = {0}公分  球體積 = {1} 立方公分", radius, volume);
            Console.Read();
        }
    }
}
