using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {

        public static int OperationCount = 0;
        public static int SwapCount = 0;
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    OperationCount++;
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
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