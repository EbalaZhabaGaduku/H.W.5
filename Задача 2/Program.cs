using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random number = new Random();
            int S,max,min;
            for (int i = 0; i < n; i++)
            {
                array[i] = number.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            max = array[0];
            min = array[0];
            foreach (var a in array)
            {
                if (a>max)
                {
                    max = a;
                }
                if (a<min)
                {
                    min = a;
                }
            }
            S = max + min;

            Console.WriteLine();
            Console.WriteLine("{0} ", S);

            Console.ReadKey();
        }
    }  
}
