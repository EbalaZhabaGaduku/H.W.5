using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random number = new Random();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = number.Next(-50, 50);
                Console.WriteLine("{0} ", array[i]);
                if (i % 2 == 0)
                {
                    if (array[i] > 0 && array[i] % 2 != 0)
                    {
                        count += 1;
                    }
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} ", count);
            Console.ReadKey();
        }
    }
}
