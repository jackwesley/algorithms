using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static double[] Sort(double[] unsortedList)
        {
            bool isSorted;
            for (int i = 0; i < unsortedList.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < unsortedList.Length - i; j++)
                {
                    if (unsortedList[j] < unsortedList[j - 1])
                    {
                        Swap(unsortedList, j, j - 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return unsortedList;
            }
            return unsortedList;
        }

        private static void Swap(double[] unsortedList, int index1, int index2)
        {
            var temp = unsortedList[index1];
            unsortedList[index1] = unsortedList[index2];
            unsortedList[index2] = temp;
        }
    }
}
