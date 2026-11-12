using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {

        public static int OperationCount = 0;
        public static int SwapCount = 0;

        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    OperationCount++;
                    Swap(array, j, j - 1);
                    j--;
                }
            }
           
        }
        private static void Swap<T>(T[] array, int first, int second)
        {
            SwapCount++;
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

    }
}