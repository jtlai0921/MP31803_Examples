using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立來源陣列
            int[] srcary = new int[] { 10, 20, 30, 40, 50, 60 };
            //建立目的陣列
            int[] dstary = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Copy(srcary, 2, dstary, 5, 3);
            Console.WriteLine(" 來源陣列      目的陣列");
            for (int k = 0; k <= 10; k++)
            {
                if (k <= 5)
                {
                    Console.WriteLine("srcary[{0}]={1}  dstary[{2}]={3}", k, srcary[k], k, dstary[k]);
                }
                else
                {
                    Console.WriteLine("              dstary[{0}]={1}", k, dstary[k]);
                }
            }
            Console.Read();
        }
    }
}
