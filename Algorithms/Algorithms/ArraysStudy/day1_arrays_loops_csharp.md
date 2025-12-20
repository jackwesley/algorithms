# Arrays + Loops 
## Goal

Build a solid foundation with arrays, loops, indexes, and edge cases.\
These concepts appear in almost every LeetCode problem.

------------------------------------------------------------------------

## Arrays in C#

Arrays store elements in contiguous memory and allow O(1) access by
index.

``` csharp
int[] nums = { 2, 7, 11, 15 };
```

------------------------------------------------------------------------

## Iterating Through Arrays

### Using `for`

Use when you need the index.

``` csharp
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
```

### Using `foreach`

Cleaner syntax, no index.

``` csharp
foreach (int num in nums)
{
    Console.WriteLine(num);
}
```

------------------------------------------------------------------------

## Index Basics

-   First element → index 0\
-   Last element → Length - 1

``` csharp
int first = nums[0];
int last = nums[nums.Length - 1];
```

❌ Common mistake:

``` csharp
nums[nums.Length];
```

------------------------------------------------------------------------

## Edge Cases

Always consider: - Empty array: `[]` - One element: `[5]` - All
duplicates: `[2,2,2]` - Negative numbers: `[-1,-2,-3]`

------------------------------------------------------------------------

# Problems

## Two Sum

Brute Force (O(n²)):

``` csharp
public int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
                return new int[] { i, j };
        }
    }
    return new int[0];
}
```

Optimized (O(n)):

``` csharp
public int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (map.ContainsKey(complement))
            return new int[] { map[complement], i };

        map[nums[i]] = i;
    }
    return new int[0];
}
```

------------------------------------------------------------------------

## Best Time to Buy and Sell Stock

``` csharp
public int MaxProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        minPrice = Math.Min(minPrice, prices[i]);
        maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
    }
    return maxProfit;
}
```

------------------------------------------------------------------------

## Contains Duplicate

``` csharp
public bool ContainsDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();
    foreach (int num in nums)
    {
        if (!set.Add(num))
            return true;
    }
    return false;
}
```

------------------------------------------------------------------------

## Plus One

``` csharp
public int[] PlusOne(int[] digits)
{
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }

    int[] result = new int[digits.Length + 1];
    result[0] = 1;
    return result;
}
```

------------------------------------------------------------------------

## Remove Duplicates from Sorted Array

``` csharp
public int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    int slow = 1;
    for (int fast = 1; fast < nums.Length; fast++)
    {
        if (nums[fast] != nums[fast - 1])
        {
            nums[slow] = nums[fast];
            slow++;
        }
    }
    return slow;
}
```

------------------------------------------------------------------------

## Summary

-   Arrays and loops are the foundation
-   Index control is critical
-   Always think about edge cases
-   These patterns appear everywhere in LeetCode
