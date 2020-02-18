using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendArray
{
    class Program
    {
        // GetMax()方法找出傳入的陣列中的最大值
        static int GetMax(int[] tempAry)
        {
            int max = tempAry[0];   //預設最大值為第一個陣列元素
            //使用陣列迴圈找出陣列中的最大值
            foreach (int temp in tempAry)
            {
                if (temp > max)
                    max = temp;
            }
            return max;  //傳回陣列中的最大值
        }

        static void Main(string[] args)
        {
            //建立並初始化ary陣列
            int[] ary = new int[] { 10, -88, -6, 34, 27 };
            Console.Write("ary陣列為 --> ");
            //逐一印出陣列中的每一個陣列元素
            for (int i = 0; i <= ary.GetUpperBound(0); i++)
            {
                Console.Write("{0} ", ary[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\nary陣列最大數為：{0}", GetMax(ary));
            Console.Read();
        }
    }
}
