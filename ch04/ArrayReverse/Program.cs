using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new String[6] { "小強", "志明", "春嬌", "阿榮", "蒙哥", "大雄" };
            int[] avg = new int[6] { 82, 66, 75, 93, 70, 89 };
            Console.WriteLine(" === 排序前 === ");
            for (int k = 0; k <= avg.GetUpperBound(0); k++)
            {
                Console.WriteLine(" name[{0}] = {1}   avg[{2}] = {3}", k, name[k], k, avg[k]);
            }
            Console.WriteLine();
            Array.Sort(avg, name);   //由小到大排序avg與name陣列
            Array.Reverse(avg);      //反轉avg陣列
            Array.Reverse(name);     //反轉name陣列
            Console.WriteLine(" === 排序後 === ");
            Console.WriteLine("       姓名           學期成績     名次 ");
            for (int k = 0; k <= avg.GetUpperBound(0); k++)
            {
                Console.WriteLine(" name1[{0}] = {1}    avg[{2}] = {3}      {4}", k, name[k], k, avg[k], k + 1);
            }
            Console.Read();
        }
    }
}
