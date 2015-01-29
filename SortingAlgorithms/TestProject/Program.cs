using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingAlgorithms;

namespace TestProject
{
    class Program
    {
        public static void printArray(long[] array)
        {
            for(int x=0; x < array.Length; x++)
            {
                Console.Write(array[x].ToString() + '\t');
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            ElementarySorts e1 = new ElementarySorts();            
            long[] arrayUnsorted = { 100, 98, 1, 55, 20, 33, 5 };
            printArray(arrayUnsorted);
            //long[] arraySorted = e1.bubbleSort(arrayUnsorted);
           //long[] arraySorted = e1.SelectionSort(arrayUnsorted);           
            //long[] arraySorted = e1.InsertionSort(arrayUnsorted);
            MergeSort m = new MergeSort();
            m.sort(arrayUnsorted);
            printArray(arrayUnsorted);
            Console.ReadLine();
        }
    }
}
