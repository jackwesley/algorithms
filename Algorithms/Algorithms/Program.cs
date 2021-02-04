using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = { 1, 1, 1, 3, 3, 5, 6, 7, 8, 9, 10 };
            var response = TopKMostFrequentElements.On(array, 2);

            Console.WriteLine("Response: [ " + string.Join(",", response) + " ]");

        }

       
    }
}
