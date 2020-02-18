using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readline1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int price, qty;
            Console.WriteLine();
            Console.WriteLine("   博碩電腦圖書廣場");
            Console.WriteLine("  ======================");
            Console.Write("   1. 書名：");
            str1 = Console.ReadLine();
            Console.Write("   2. 售價：");
            price = int.Parse(Console.ReadLine());
            Console.Write("   3. 數量：");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ======================");
            Console.WriteLine("   4. 金額：{0}", price * qty);
            Console.Read();
        }
    }
}
