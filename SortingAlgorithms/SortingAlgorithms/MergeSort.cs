using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public  class MergeSort
    {
        public MergeSort() { 
        }
        //Stable (No swaps needed) -mergesort uses between 1/2 N lg N and N lg N compares and at most 6 N lg N array accesses to sort any array of length N. 
        //Mergesort is an asymptotically optimal compare-based sorting algorithm. 
        //That is, both the number of compares used by mergesort in the worst case and the minimum number of compares that any compare-based sorting algorithm can guarantee are ~N lg N. 
        //Only CON is that extra space propotional to N
        
        //https://www.youtube.com/watch?v=TzeBrDU-JaY EXCELLENT

        public void sort<T>(T[] array) where T: IComparable
        {
            T[] auxArray = new T[array.Length];
            sort(array, auxArray, 0, array.Length - 1);
        }
        private void sort<T>(T[] arrayToSort, T[] auxArray, int low, int high) where T : IComparable
        {
            if (high <= low) return;
            int mid = (high + low) / 2;
            sort(arrayToSort, auxArray, low, mid);
            sort(arrayToSort, auxArray, mid+1, high);
            merge(arrayToSort, auxArray, low, high, mid);
        }
        private bool merge<T>(T[] arrayToSort, T[] auxArray, int low, int high, int mid) where T : IComparable
        {
            if(isSorted<T>(arrayToSort,low,mid)== false)
            {
                return false;
            }
            if (isSorted<T>(arrayToSort, mid+1, high) == false)
            {
                return false;
            }
            int i = low;
            int j = mid + 1;
            //copy a[] to aux[]
            for(int k= low; k <= high ; k++)
            {
                auxArray[k] = arrayToSort[k];
            }
            //
            for(int k= low; k <= high ; k++)
            {
                if (i > mid) 
                {
                    arrayToSort[k] = auxArray[j];
                    j++;
                }
                else if(j > high)
                {
                    arrayToSort[k] = auxArray[i];
                    i++;
                }
                else if(less(auxArray[i] , auxArray[j])) //aux[i] < aux[j]
                {
                    arrayToSort[k] = auxArray[i];
                    i++;
                }
                else if (less(auxArray[j], auxArray[i]))//aux[j] < aux[i]
                {
                    arrayToSort[k] = auxArray[j];
                    j++;
                }
                
            }
           
            return true;
            
        }

        public bool isSorted<T>(T[] array, int low, int high) where T : IComparable
        {
            for(int x=low+1; x <= high; x++)
            {
                if(less(array[x],array[x-1]) == false)
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
