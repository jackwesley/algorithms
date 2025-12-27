# Day 2 --- Hash Maps & Hash Sets (C#)

## Goal

Learn how to use hash-based data structures to achieve **O(1)**
average-time lookups. This pattern drastically improves performance in
many LeetCode problems.

------------------------------------------------------------------------

## Hash Map vs Hash Set

### HashMap (Dictionary)

-   Stores **key → value**
-   Fast lookup, insert, delete

``` csharp
Dictionary<int, int> map = new Dictionary<int, int>();
map[5] = 10;
int value = map[5];
```

### HashSet

-   Stores **unique values only**
-   Great for detecting duplicates

``` csharp
HashSet<int> set = new HashSet<int>();
set.Add(3);
bool exists = set.Contains(3);
```

------------------------------------------------------------------------

## When to Use Hashing

Use a hash structure when you need: - Fast existence checks - Frequency
counting - Index tracking - Duplicate detection

------------------------------------------------------------------------

## Common Edge Cases

-   Empty input
-   Repeated values
-   Negative numbers
-   Large input size (performance matters)

------------------------------------------------------------------------

# Problems

## Two Sum (Optimized)

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

## Valid Anagram

``` csharp
public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    Dictionary<char, int> count = new Dictionary<char, int>();

    foreach (char c in s)
        count[c] = count.GetValueOrDefault(c, 0) + 1;

    foreach (char c in t)
    {
        if (!count.ContainsKey(c) || count[c] == 0)
            return false;
        count[c]--;
    }

    return true;
}
```

------------------------------------------------------------------------

## Intersection of Two Arrays

``` csharp
public int[] Intersection(int[] nums1, int[] nums2)
{
    HashSet<int> set = new HashSet<int>(nums1);
    HashSet<int> result = new HashSet<int>();

    foreach (int num in nums2)
    {
        if (set.Contains(num))
            result.Add(num);
    }

    return result.ToArray();
}
```

------------------------------------------------------------------------

## First Unique Character in a String

``` csharp
public int FirstUniqChar(string s)
{
    Dictionary<char, int> count = new Dictionary<char, int>();

    foreach (char c in s)
        count[c] = count.GetValueOrDefault(c, 0) + 1;

    for (int i = 0; i < s.Length; i++)
    {
        if (count[s[i]] == 1)
            return i;
    }

    return -1;
}
```

------------------------------------------------------------------------

## Happy Number

``` csharp
public bool IsHappy(int n)
{
    HashSet<int> seen = new HashSet<int>();

    while (n != 1 && !seen.Contains(n))
    {
        seen.Add(n);
        n = SumOfSquares(n);
    }

    return n == 1;
}

private int SumOfSquares(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        sum += digit * digit;
        n /= 10;
    }
    return sum;
}
```

------------------------------------------------------------------------


## Summary

-   Hash maps and sets enable O(1) average lookups
-   Perfect for duplicates, counting, and fast searches
-   Essential for medium-level LeetCode problems
