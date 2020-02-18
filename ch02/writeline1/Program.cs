using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeline1
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 120, qty = 50;
            Console.WriteLine("售價：{0}    數量：{1}", price, qty);
            Console.WriteLine();
            Console.WriteLine("打八折後  總金額：{0}", price * qty * 0.8);
            Console.Read();
        }
    }
}
