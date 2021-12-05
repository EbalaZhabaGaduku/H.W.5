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
            Console.WriteLine("Введите целочисленное значение N");

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random r 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 3;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
