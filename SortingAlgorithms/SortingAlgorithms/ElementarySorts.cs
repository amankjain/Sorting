﻿using System;
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
        public long[] SelectionSort(long[] array)
        {
            return array;
        }
        public long[] bubbleSort(long[] array)
        {
            //optimzation: Check if swaps are made in the iteration, no swaps then exit, because it means its already sorted
            /*C++
             bool swapped = true;

                  int j = 0;

                  int tmp;

                  while (swapped) {

                        swapped = false;

                        j++;

                        for (int i = 0; i < n - j; i++) {

                              if (arr[i] > arr[i + 1]) {

                                    tmp = arr[i];

                                    arr[i] = arr[i + 1];

                                    arr[i + 1] = tmp;

                                    swapped = true;

                              }

                        }

                  }
             * */

            //N^2 
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
