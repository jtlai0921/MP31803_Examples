using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace election
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            //建立候選人陣列
            string[] name = new string[] { "陳櫻櫻", "蔡酒酒", "柯誰誰" };
            int[] tot = new int[name.Length];     //存放各候選人總得票數
            int[,] vote = new int[3, 3];          //存放各候選人各區得票數
            // 輸入各選區各候選人得票數
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(" 第 {0} 選區各候選人得票數:", i + 1);
                for (k = 0; k <= 2; k++)
                {
                    Console.Write(" {0}. {1} :", (k + 1), name[k]);
                    vote[i, k] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" ----------------------------------");
            }
            // 計算各候選人總得票數存入tot陣列中
            for (i = 0; i <= 2; i++)
            {
                for (k = 0; k <= 2; k++)
                {
                    tot[i] += vote[k, i];
                }
            }
            // 顯示結果
            Console.WriteLine(" ==================================");
            Console.WriteLine("   候選人  第一區  第二區 第三區 總得票數");
            Console.WriteLine(" ====== ======  ======  ======  =======");
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine(" {0}  {1}   {2}   {3}   {4}", name[i], vote[0, i], vote[1, i], vote[2, i], tot[i]);
            }
            // 對存放各候選人總得票數的tot陣列作遞減排序
            Array.Sort(tot, name);   //排序tot，name依tot索引做排序
            Array.Reverse(tot);      //反轉tot陣列
            Array.Reverse(name);     //反轉name陣列
            Console.WriteLine();
            Console.WriteLine(" === {0} 最高票當選, 共計: {1} 票", name[0], tot[0]);
            Console.Read();
        }
    }
}
