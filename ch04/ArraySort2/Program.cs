using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort2
{
    class Program
    {
        static void Main(string[] args)
        {
            //學生姓名name陣列
            string[] name = new string[6] { "小強", "志明", "春嬌", "阿榮", "蒙哥", "大雄" };
            //學期成績avg陣列
            int[] avg = new int[6] { 82, 66, 75, 93, 70, 89 };
            Console.WriteLine(" === 排序前 === ");
            for (int k = 0; k <= avg.GetUpperBound(0); k++)
            {
                Console.WriteLine(" name[{0}] = {1}    avg[{2}] = {3}", k, name[k], k, avg[k]);
            }
            Console.WriteLine();
            Array.Sort(avg, name);  // name陣列依avg陣列做由小而大排序
            Console.WriteLine(" === 排序後 === ");
            for (int k = 0; k <= avg.GetLength(0) - 1; k++)
            {
                Console.WriteLine(" name[{0}] = {1}    avg[{2}] = {3}", k, name[k], k, avg[k]);
            }
            Console.Read();
        }
    }
}
