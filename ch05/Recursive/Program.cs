using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    { 
        //定義sum方法可傳回遞迴結果
        static int sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return sum(n-1) + n;
        }

        static void Main(string[] args)
        {
            int keyin;
            Console.Write("=== 請輸入整數 n 值(n>2) : ");
            try    //監控可能發生例外的程式
            {
                keyin = int.Parse(Console.ReadLine());
                int ans = sum(keyin);
                Console.WriteLine();
                Console.WriteLine("1 + 2 + ... + {0} = {1}", keyin, ans);
            }
            catch (Exception ex)       //補捉並處理發生例外
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
