using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace Algorithms.ArraysStudy
{
    public static class Arrays
    {
        public static void ReadAllElements()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Brute force O(n^2)
        /// </summary>
        public static void TwoSumsToGetTarget()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 9;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {target}");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Optmized HashMap - O(n)
        /// </summary>
        public static void TwoSumsToGetTargetOptimized()
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] arr = { 2, 7, 11, 15, 5 };
            int target = 9;

            for (int i = 0; i < arr.Length; i++)
            {
                var complement = target - arr[i];

                if (map.ContainsKey(complement))
                {
                    Console.WriteLine($"{arr[map[complement]]} + {arr[i]} == {target}");
                    return;
                }

                map[arr[i]] = i;
            }
        }

        /// <summary>
        /// Key Idea
        ///Track the minimum price so far
        ///Calculate profit at each step
        /// </summary>
        public static void MaxProfit()
        {
            int[] prices = { 3, 8, 4, 5, 10 };
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            Console.WriteLine(maxProfit.ToString());
        }


        /// <summary>
        /// Problem:
        ///Check if any value appears more than once.
        /// </summary>
        public static void ContainsDuplicateBruteForce()
        {
            int[] arr = { 3, 8, 4, 5, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Has duplicates {arr[i]} == {arr[j]}");
                    }
                }
            }
        }

        /// <summary>
        /// Problem:
        ///Check if any value appears more than once.
        /// </summary>
        public static void ContainsDuplicateHashSet()
        {
            int[] arr = { 3, 8, 4, 5, 9 };
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                {
                    Console.WriteLine($"Duplicated number {arr[i]}");
                    return;
                }

            }
            Console.WriteLine("There are no duplicated values in the array");
        }

        /// <summary>
        /// Problem:
        // Add 1 to a number represented as an array.
        /// </summary>
        public static void PlusOne()
        {
            int[] arr = { 9, 9, 9, 0 };
            Console.WriteLine("Before sum 1");
            Console.WriteLine(string.Join(", ", arr));

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 9)
                {
                    arr[i]++;
                    Console.WriteLine("After sum 1");
                    Console.WriteLine(string.Join(", ", arr));
                    return;

                }
                arr[i] = 0;
            }

            int[] result = new int[arr.Length + 1];
            result[0] = 1;
            Console.WriteLine("After sum 1");
            Console.WriteLine(string.Join(", ", result));
        }

        /// <summary>
        /// Key Idea
        ///Array is already sorted
        ///Use a slow pointer to track unique values
        /// </summary>
        public static void RemoveDuplicates()
        {
            int[] nums = { 9, 9, 9, 0 };
            if (nums.Length == 0)
            {
                Console.WriteLine("Empty Array");
                return;
            }

            int slow = 1;

            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    //Add value of nums[fast] to position nums[slow]
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            Console.WriteLine(slow);
        }
        /// <summary>
        /// Given an array of positive integers nums and a target number, find the smallest size of a contiguous subarray whose sum is ≥ target.
        /// If it does not exist, return 0.

        /// </summary>
        public static void MinSubArray()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            int sum = 0;
            int left = 0;
            int minLenght = int.MaxValue;


            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (sum >= target)
                {
                    minLenght = Math.Min(minLenght, right - left + 1);
                    sum = sum - nums[left];
                    left++;
                }
            }
            Console.WriteLine(minLenght);
        }
        /// <summary>
        /// Longest Subarray With Sum ≤ K
        /// Statement
        /// Given an array of positive integers nums and an integer k, find the largest size of a contiguous subarray whose sum is less than or equal to k.
        /// Return only the size.
        /// </summary>

        public static void MaxSubArray()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 4;
            int sum = 0;
            int maxLenght = 0;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (sum > target)
                {
                    sum = sum - nums[left];
                    left++;
                }

                maxLenght = Math.Max(maxLenght, right - left + 1);
            }

            Console.WriteLine(maxLenght);
        }
    }
}