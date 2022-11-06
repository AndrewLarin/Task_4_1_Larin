using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int l = B;
            while (A >= C)
            {
                while (B >= C)
                {
                 B -= C;
                 k++;
                }
                A -= C;
                B = l;

            }
            Console.Write("Количество квадратов: {0}", k);
            Console.ReadKey();
        }

    }
}
