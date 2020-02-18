using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndObj = new Random();
            //第一組 1~10 的五個亂數
            Console.Write("== Pass1：");
            for (int k = 1; k <= 5; k++)
            {
                Console.Write(" {0}", rndObj.Next(1, 11));
            }
            Console.WriteLine();
            //第二組 1~10 的五個亂數
            Console.Write("== Pass2：");
            for (int k = 1; k <= 5; k++)
            {
                Console.Write(" {0}", rndObj.Next(1, 11));
            }
            Console.Read();
        }
    }
}
