using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var array = new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };


            var response = LongestSubArray.Find(array, 3);

            Console.WriteLine(response);

            //foreach (var res in response)
            //{
            //    Console.WriteLine("Response: [ " + string.Join(",", res) + " ]");
            //}
        }
    }
}
