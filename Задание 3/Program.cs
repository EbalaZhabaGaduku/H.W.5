using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random number = new Random();
            int z;
            for (int i = 0; i < n; i++)
            {
                
                array[i] = number.Next(-50, 50);
                
                for (int j = 0; j < n/2; j++)
                {
                    if (array[i] < array[j])
                    {
                        z = array[i];
                        array[i] = array[j];
                        array[j] = z;
                    }
                }
                for (int j = n/2; j < n ; j++)
                {
                    if (array[i] > array[j])
                    {
                        z = array[i];
                        array[i] = array[j];
                        array[j] = z;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
                Console.WriteLine();
           
            Console.ReadKey();
        }
    }
}
