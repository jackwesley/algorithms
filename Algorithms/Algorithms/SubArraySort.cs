namespace Algorithms
{
    /*
     Neste desafio você deverá construir uma função que recebe um array com ao menos dois elementos numéricos. Esta função deve retornar um array com os indices mínimo e máximo do menor subarray que precisa ser ordenado para que todo o array passe a ser ordenado também.Se o array passado estiver totalmente ordenado, a sua função deve retornar [-1, -1].

    Exemplos
    Sua função receberá um array: [1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19]

        Sua função deverá retornar: [3, 9]
     */
    public static class SubArraySort
    {
        public static int[] Sort(int[] array)
        {
            int max_number = int.MinValue;
            int min_number = int.MaxValue;


            for (int index = 0; index < array.Length; index++)
            {
                if (!isSorted(array, index))
                {
                    if (array[index] > max_number)
                        max_number = array[index];
                    if (array[index] < min_number)
                        min_number = array[index];
                }
            }
            if (min_number == int.MaxValue)
                return new int[] { -1, -1 };

            int min_index = 0;
            while (min_number >= array[min_index])
            {
                min_index += 1;
            }

            int max_index = array.Length - 1;
            while (max_number <= array[max_index])
            {
                max_index -= 1;
            }

            return new int[] { min_index, max_index };
        }

        private static bool isSorted(int[] array, int index)
        {
            if (index == 0)
                return array[index] <= array[index + 1];
            if (index == array.Length - 1)
                return array[index] >= array[index] - 1;

            return array[index] <= array[index + 1] && array[index] >= array[index - 1];
        }
    }
}
