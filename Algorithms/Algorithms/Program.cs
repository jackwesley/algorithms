using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var array = new int[] { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };


            var response = SubArraySort.Sort(array);

            foreach (var res in response)
            {
                Console.WriteLine("Response: [ " + string.Join(",", res) + " ]");
            }
        }
    }
}
