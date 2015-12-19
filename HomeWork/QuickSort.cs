using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class QuickSort
    {
        public static void Sort(int[] array, int first, int count)
        {
            SortPrivate(array, first, first + count - 1);
        }
 
        static void SortPrivate (int [] array, int first, int last)
        {
            if (first < last)
            {
                int s = Separation (array, first, last);
                SortPrivate (array, first, s - 1);
                SortPrivate (array, s + 1, last);
            }
        }
        static int Separation (int[] array, int first, int last)
        { 
            int pivot = array [last];
            int temp;
            int i = first;
            for (int k = first; k < last; k++)
            {
                if (array[k] <= array[last])
                {
                    temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                    i++;
                }
            }
            array[last] = array[i];
            array [i] = pivot;

            return i;
        }
      

    }
}
