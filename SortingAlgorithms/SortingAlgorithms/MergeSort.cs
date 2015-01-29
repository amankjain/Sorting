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
            //int mid = low + (high - low) / 2; //both ways of calculating mid seem to work
            int mid = (high + low) / 2;
            sort(arrayToSort, auxArray, low, mid);         //DOES not really sort, recursively breaks subarrays until only 1 element left
            sort(arrayToSort, auxArray, mid + 1, high);    //DOES not really sort, recursively breaks subarrays until only 1 element left
            merge(arrayToSort, auxArray, low, high, mid);  //MERGES subarrays starting with size 1,2,...until two half sized arrays 
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
            int i = low;     //Left Array start until mid
            int j = mid + 1; //Right array start until high
            //copy a[] to aux[]
            for(int k= low; k <= high ; k++) //K goes from low to high. //k < high for 2 or more elements and k=h for 1 element?  . Can also use set of 3 while loops as per yopu tube video 
            {
                auxArray[k] = arrayToSort[k];  
            }
            //
            for(int k= low; k <= high ; k++)
            {
                if (i > mid)  //if all left array items are picked
                {
                    arrayToSort[k] = auxArray[j];
                    j++;
                }
                else if (j > high) //if all right array items are picked
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
                if(less(array[x-1],array[x]) == false)
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
