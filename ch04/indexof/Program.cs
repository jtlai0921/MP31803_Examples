using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Jack", "Tom", "Fred", "Mary", "Lucy", "Jane" };
            int index1 = Array.IndexOf(name, "Tom");
            Console.WriteLine(index1);
            int index2 = Array.IndexOf(name, "Tom",3);
            Console.WriteLine(index2);
            string str1 = "Mary";
            int start = 1;
            int offset = 4;
            int index3 = Array.IndexOf(name,str1,start,offset);
            Console.WriteLine(index3);
            Console.Read();
        }
    }
}
