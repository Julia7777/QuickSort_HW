using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 5, 4, 6, 7, 1, 2, 3, 12, 9};
            Console.WriteLine("Before sorting");
            print(array);
            QuickSort.Sort(array, 0, array.Length);
            Console.WriteLine("After sorting");
            print(array);
            Console.ReadKey();
        }
        public static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
