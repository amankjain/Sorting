using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortTrial
{
    public class QuickSort
    {
        public void sort<T>(T[] array) where T : IComparable
        {
            Shuffle(array);
            sort(array,  0, array.Length - 1);
        }
        private void sort<T>(T[] arrayToSort,  int low, int high) where T : IComparable
        {
            if (high <= low) return;            
            int j= partition(arrayToSort, low, high);  
            sort(arrayToSort, low, j-1);    
            sort(arrayToSort, j + 1, high);
           
        }
        private void swap<T>(T[] arrayToSort, int x, int y) where T:IComparable
        {
            T value = arrayToSort[x];
            arrayToSort[x] = arrayToSort[y];
            arrayToSort[y] = value;
        }
        private int partition<T>(T[] arrayToSort,  int low, int high) where T : IComparable
        {
            int i = low;
            int j = high + 1;
            T value= arrayToSort[i];
            while(true)
            {
                while(less(arrayToSort[++i], value))
                {
                    if(i >= high)
                    {
                        break;
                    }
                }
                while (!less(arrayToSort[--j], value))
                {
                    if (j <= low)
                    {
                        break;
                    }
                }
                if(i >= j)
                {
                    break;
                }
                swap(arrayToSort, i, j);

            }
            swap(arrayToSort, low, j);
            return j;
        }
        public bool isSorted<T>(T[] array, int low, int high) where T : IComparable
        {
            for (int x = low + 1; x <= high; x++)
            {
                if (less(array[x - 1], array[x]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public bool less<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) < 0; //<0 is less thab ;0 is same; >0 is greater than
        }
        public  void Shuffle<T>( IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
