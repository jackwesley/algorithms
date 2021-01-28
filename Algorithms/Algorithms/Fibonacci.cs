namespace Algorithms
{
    public static class Fibonacci
    {
        public static int CalculateRecursive(int number)
        {

            if (number < 3)
                return 1;
            return CalculateRecursive(number - 1) + CalculateRecursive(number - 2);
        }

        private static int CalculateNotRecursive(int num)
        {
            if (num < 3)
                return 1;

            int previous = 1;
            int current = 1;


            for (int i = 2; i < num; i++)
            {
                int next = previous + current;

                previous = current;
                current = next;
            }

            return current;
        }
    }
}
