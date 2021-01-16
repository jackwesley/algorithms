using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var array = new int[] { 7, 6, 4, -1, 1, 2 };



            var target = 16;

            var response = FourSum.SumOn2(array, target);

            foreach (var res in response)
            {
                Console.WriteLine("Response: [ " + string.Join(",", res) + " ]");
            }
        }
    }
}
