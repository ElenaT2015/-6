using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку без знаков препинания");
            string startString = Console.ReadLine();
            int nt = startString.Length;
            string startString1 = startString.Substring(0, nt).ToLower();
            string nospace = startString1.Replace(" ","");
            int n = nospace.Length;
            char[] plindrom = nospace.ToCharArray();
            bool flag = true;
            int m = (n / 2);
            for (int i = 0; i < m; i++)
            {
                if (plindrom[i] != plindrom[n - i - 1])
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine(" Введеная строка являтся полиндромом!");
            }
            else
            {
                Console.WriteLine(" Введеная строка не являтся полиндромом!");
            }
                Console.ReadKey();                     
        }
    }
}
 
