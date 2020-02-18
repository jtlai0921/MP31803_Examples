using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] avg = new int[5] { 75, 86, 42, 63, 91 };
            Console.WriteLine(" === 排序前 === ");
            for (int k = 0; k <= avg.GetUpperBound(0); k++)  // 印出avg陣列排序前的結果
            {
                Console.WriteLine(" avg[{0}] = {1}", k, avg[k]);
            }
            Console.WriteLine();   //換行
            Array.Sort(avg);  //由小到大排序avg陣列
            Console.WriteLine(" === 排序後 === ");
            for (int k = 0; k <= avg.Length - 1; k++)  // 印出avg陣列排序後的結果
            {
                Console.WriteLine(" avg[{0}] = {1}", k, avg[k]);
            }
            Console.Read();
        }
    }
}
