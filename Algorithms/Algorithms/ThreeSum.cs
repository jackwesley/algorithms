using System;
using System.Collections.Generic;


namespace Algorithms
{
    /*
     O Three sum é uma variação do problema Two Sum.
        A idéia deste problema é identificar todos os três números que quando somados resultem em um valor especificado.

    Exemplos
    Se o array é [12, 3, 1, 2, -6, 5, -8, 6] e o target é 0. Neste caso, seu programa deve retornar:
    [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]
    A soma de todos os valores das listas acima será igual a zero.
    */
    public static class ThreeSum
    {
        public static List<int[]> Sum(int[] array, int target)
        {
            List<int[]> response = new List<int[]>();

            int pointerIndex1 = 0;
            int pointerIndex2 = 1;

            while (pointerIndex2 < array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == pointerIndex1 || i == pointerIndex2)
                        i++;
                    else if (array[pointerIndex1] + array[pointerIndex2] + array[i] == target)
                    {
                        var responseArray = new int[] { array[pointerIndex1], array[pointerIndex2], array[i] };
                        Array.Sort(responseArray);
                        response.Add(responseArray);
                    }
                }
                pointerIndex1++;
                pointerIndex2++;
            }

            return response;
        }


        public static List<int[]> SumOn2(int[] array, int target)
        {
            List<int[]> response = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                int current = i;
                var left = current + 1;
                var right = array.Length - 1;

                while (left < right)
                {

                    int sum = array[current] + array[left] + array[right];

                    if (sum > target)
                        right--;
                    else if (sum < target)
                        left++;
                    else
                    {
                        int[] result = new int[] { array[current], array[left], array[right] };
                        Array.Sort(result);
                        response.Add(result);

                        left++;
                        right--;
                    }
                }
            }

            return response;
        }
    }
}
