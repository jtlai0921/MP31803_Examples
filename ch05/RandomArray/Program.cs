using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        //GetRnd()方法取得不重複的亂數值
        static void GetRnd(int[] ranAry, int min, int max, int num)
        {
            int temp;                 // 存放暫時取得之亂數值
            int n = 0;                 // 存放目前的陣列索引值
            bool more;              // 記錄亂數是否重複
            Random ranObj = new Random();
            do
            {
                more = false;
                temp = ranObj.Next(min, max + 1);   // 取得亂數值
                for (int k = 0; k <= n; k++)                // 檢查取得之亂數值是否重複
                {
                    if (ranAry[k] == temp)
                    {
                        more = true;               // 如果重複, more為true
                        break;                        // 如果more為true, 則重新取得亂數
                    }
                }
                if (more == false)                // 若more為false, 表示取得之亂數沒有重複
                {
                    ranAry[n] = temp;          // 則亂數值指定給陣列元素                  
                    n++;                             // 且陣列索引值加1
                }
            } while (n < num);
        }

        static void Main(string[] args)
        {
            int min = 10, max = 20, num = 8;
            int[] ran = new int[num];
            // 取得min(10)~max(20)之間num(8)個不重複出現的亂數值
            GetRnd(ran, min, max, num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("第{0}個亂數: {1}", i + 1, ran[i]);
            }
            Console.Read();
        }
    }
}
