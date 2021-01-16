using System.Collections.Generic;


namespace Algorithms
{
    /*  O Four Sum é uma variação do problema Two Sum e Three Sum.
        A idéia deste problema é identificar todos os quatro números que quando somados resultem em um valor especificado.

        Exemplos
        Se o array é[7, 6, 4, -1, 1, 2] e o target é 16. Neste caso, seu programa deve retornar:
        [[7, 6, 4, -1], [7, 6, 1, 2]] 
        A soma de todos os valores das listas acima será igual a 16.
    */
    public static class FourSum
    {
        public static List<int[]> SumOn2(int[] array, int target)
        {
            List<int[]> results = new List<int[]>();
            Dictionary<int, List<int[]>> sums = new Dictionary<int, List<int[]>>();

            for (int pointer = 0; pointer < array.Length; pointer++)
            {
                for (int foward = pointer + 1; foward < array.Length; foward++)
                {
                    int my_sum = array[pointer] + array[foward];
                    int diff = target - my_sum;
                    if (sums.TryGetValue(diff, out List<int[]> sum))
                    {
                        foreach (var arrInt in sum)
                        {
                            results.Add(new int[] { arrInt[0], arrInt[1], array[pointer], array[foward] });
                        }

                    }

                }

                for (int previous = 0; previous < pointer; previous++)
                {
                    int my_sum = array[previous] + array[pointer];
                    if (sums.TryGetValue(my_sum, out List<int[]> sum))
                    {
                        sum.Add(new int[] { array[previous], array[pointer] });
                    }
                    else
                    {
                        sums.Add(my_sum, new List<int[]> { new int[] { array[previous], array[pointer] } });
                    }
                }
            }

            return results;
        }
    }
}
