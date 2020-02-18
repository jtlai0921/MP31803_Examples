using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;   //宣告用來存放搜尋結果的陣列元素
            string myobject;   //宣告欲搜尋的資料
            string[] word = new string[6] { "book", "pen", "apple", "cat", "mouse", "ox" };
            Array.Sort(word);     // word陣列遞增排序            .
            Console.WriteLine(" === 排序後 === ");
            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine(" {0}.word[{1}] = {2} ", k + 1, k, word[k]);
            }
            Console.WriteLine("----------------------------");
            Console.Write("請輸入欲查詢的單字 : ");
            myobject = Console.ReadLine(); //輸入欲搜尋的資料
            //搜尋word陣列是否有myobject資料，若找到則傳回註標值並指定給index
            index = Array.BinarySearch(word, myobject);
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("*** 查詢結果 : ");
            Console.WriteLine();
            if (index < 0)   //index小於0，表示找不到資料
            {
                Console.WriteLine("== 該資料不存在 !");
            }
            else
            {
                Console.WriteLine("== 該資料位於陣列中 word[{0}] = {1}", index, word[index]);
                Console.WriteLine("\n   相當於陣列中的第 {0} 個元素....", index + 1);
            }
            Console.Read();
        }
    }
}
