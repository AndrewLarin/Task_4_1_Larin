using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1_Larin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (2 * i) - 1;
            }
            Console.Write("Ваш ответ: ");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
