using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort
    {
        //Stable (No swaps needed) -mergesort uses between 1/2 N lg N and N lg N compares and at most 6 N lg N array accesses to sort any array of length N. 
        //Mergesort is an asymptotically optimal compare-based sorting algorithm. 
        //That is, both the number of compares used by mergesort in the worst case and the minimum number of compares that any compare-based sorting algorithm can guarantee are ~N lg N. 
        //Only CON is that extra space propotional to N

        public void sort<T>(T[] array) where T: IComparable
        {
            T[] auxArray = new T[array.Length];  
            
        }
        private void sort<T>(T[] arrayToSort, T[] auxArray, int low, int high)
        {
            
        }
        private void merge<T>(T[] arrayLow, T[] arrayHigh, T[] auxArray, int low, int high, int mid)
        {
            
        }

        public bool isSorted<T>(T[] array) where T : IComparable
        {
            for(int x=0; x < array.Length; x++)
            {
                if(less(array[x],array[x+1]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public bool less<T>(T a, T b) where T: IComparable
        {
            return a.CompareTo(b) < 0; //<0 is less thab ;0 is same; >0 is greater than
        }

    }
}
