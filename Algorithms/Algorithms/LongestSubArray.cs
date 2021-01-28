namespace Algorithms
{
    /*
     
    Dado um array numbers com valores 0 e 1, nós podemos alterar K valores de 0
    para 1.
    Retorne o tamanho do maior subarray contínuo que contém apenas 1.
    Exemplo 1:
    Entrada:
    numbers = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], K = 2
    numbers alterados = [1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0], K = 2
    Saída: 6    
    Exemplo 2:
    Entrada:
    numbers = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], K = 3
    numbers alterados = [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1], K = 3
    Saída: 10
     
     */
    public static class LongestSubArray
    {
        public static int Find(int[] numbers, int k)
        {
            int leftPointer = 0;
            int rightPointer;

            for (rightPointer = 0; rightPointer < numbers.Length; rightPointer++)
            {
                if (numbers[rightPointer] == 0)
                {
                    k--;

                }

                if (k < 0)
                {
                    if (numbers[leftPointer] == 0)
                        k++;

                    leftPointer++;
                }
            }
            int result = rightPointer - leftPointer;

            return result;
        }

    }
}
