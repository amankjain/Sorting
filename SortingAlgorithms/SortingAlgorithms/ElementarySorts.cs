using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class ElementarySorts
    {
        public void swap(long[] array, int positionX, int positionY)
        {
            long value = array[positionX];
            array[positionX] = array[positionY];
            array[positionY] = value;
        }
        public long[] bubbleSort(long[] array)
        {
            for (int x = 0; x < array.Length; x++ )
            {
                for (int y = x+1; y < array.Length; y++)
                {
                    if (y <= (array.Length - 1))
                    {
                        if (array[y] < array[x])
                        {
                            swap(array, x, y);
                        }
                    }
                }
            }
            return array;
        }
    }
}
