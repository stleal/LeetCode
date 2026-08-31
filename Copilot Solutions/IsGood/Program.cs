using System;
using System.Collections.Generic;

public class Solution
{

    public static void Main()
    {
        Solution sol = new Solution();

        int[] nums1 = { 1, 2, 3, 3 };
        Console.WriteLine($"Example 1: {sol.IsGood(nums1)}"); // True

        int[] nums2 = { 1, 2, 3, 4 };
        Console.WriteLine($"Example 2: {sol.IsGood(nums2)}"); // False
    }

    public bool IsGood(int[] nums)
    {
        int n = nums.Length - 1;

        var freq = new Dictionary<int, int>();

        foreach (int x in nums)
        {
            if (!freq.ContainsKey(x))
                freq[x] = 0;
            freq[x]++;
        }

        if (freq.GetValueOrDefault(n, 0) != 2)
            return false;

        for (int i = 1; i < n; i++)
        {
            if (freq.GetValueOrDefault(i, 0) != 1)
                return false;
        }

        return nums.Length == n + 1;
    }
}