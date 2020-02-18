using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] stuary = new string[3][];   //先建立3列
            //第0列stuary[0][0]~stuary[0][3]
            stuary[0] = new string[] { "林子厚", "反應敏捷", "熱心公務", "表現大方" };
            //第1列stuary[1][0]~stuary[1][4]		
            stuary[1] = new string[] { "趙玲玲", "溫和良善", "主動求知", "做事負責", "待人親切" };
            //第2列stuary[2][0]~stuary[2][1]
            stuary[2] = new string[] { "吳學剛", "性情率真", "尚知勤學" };
            //取得整個stuary陣列共有多少列
            for (int i = 0; i <= stuary.Length - 1; i++)
            {
                Console.Write("第{0}列: ", i);
                //取得stuary陣列的第 i 列共有多少個陣列元素
                for (int k = 0; k <= stuary[i].Length - 1; k++)
                {
                    Console.Write("{0} ", stuary[i][k]);
                }
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
}
