using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = { 100,  23,  28, 33, 1, 55, 19,5, 2 };
            QuickSort<long> qs = new QuickSort<long>();
            Console.WriteLine("Testing QuickSOrt");
            for (int x = 0; x < array.Length; x++ )
            {
                Console.Write(array[x].ToString() + '\t');
            }
            Console.WriteLine(" ");
                qs.sort(array);
                for (int x = 0; x < array.Length; x++)
                {
                    Console.Write(array[x].ToString() + '\t');
                }
                Console.ReadLine();
        }
    }
}
