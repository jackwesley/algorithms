using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /*
    O Two Sum é bastante comum durante entrevistas.Seu objetivo é identificar um par de números que somados batam com o valor da variável target.
    Ele pode ser escrito em um algoritmo que roda no tempo O(n).

    Exemplos
    Se o array é[4, 1, 2, -2, 11, 15, 1, -1, -6, -4] e o target é 9. Neste caso, seu programa deve retornar: [-2, 11]
    O motivo é bastante simples:
    -2 + 11 = 9 */
    public class TwoSum
    {
        public static int[] SumON2(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[] { };
        }


        public static int[] SumOn(int[] array, int target)
        {
            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            for (int i = 0; i < array.Length; i++)
            {
                var targetMinusPointer = target - array[i];
                if (!dictionary.ContainsKey(targetMinusPointer))
                    dictionary.Add(array[i], true);
                else
                    return new int[] { array[i], targetMinusPointer };
            }
            return new int[] { };
        }

        public static int[] SumOnLogn(int[] array, int target)
        {
            Array.Sort(array);
            var leftPointer = 0;
            var rigthPointer = array.Length - 1;

            while (leftPointer < rigthPointer)
            {
                var numbersSum = array[leftPointer] + array[rigthPointer];
                if (numbersSum == target)
                    return new int[] { array[leftPointer], array[rigthPointer] };
                else if (numbersSum < target)
                    leftPointer++;
                else if (numbersSum > target)
                    rigthPointer--;
            }

            return new int[] { };
        }
    }
}
