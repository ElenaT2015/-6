using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку без знаков препинания");
            string startString  = Console.ReadLine();
            string [] startArray = startString.Split();
            int n = 0;
            int m = 0;
            int v = startArray.Length;
            for (int i = 0; i < v; i++)
                if (startArray[i].Length > n)
                {
                    n = startArray[i].Length;
                    m = i;
                }
                    Console.WriteLine("{0}", startArray[m]);
            Console.ReadKey();
        }
    }
}
