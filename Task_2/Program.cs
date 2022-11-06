using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k = 0; // +
            int h = 0; // -
            do
            {
              n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    k++;
                else if (n < 0)
                    h++;

            }
            
            while (n != 0);
            if (k > h) Console.WriteLine("Количество положительных чисел {0} больше, чем отрицательных {1}", k, h);
            if (h > k) Console.WriteLine("Количество положительных чисел {0} меньше, чем отрицательных {1}", k, h);
            if (h == k) Console.WriteLine("Количество положительных чисел {0} равно количеству отрицательных {1}", k, h);
        }
    }
}
