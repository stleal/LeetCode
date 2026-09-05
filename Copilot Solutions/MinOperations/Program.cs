using System;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        int operations = 0;

        foreach (int num in nums)
        {
            int remainder = ((num % 3) + 3) % 3;
            operations += Math.Min(remainder, 3 - remainder);
        }

        return operations;
    }
}

public class Program
{
    private static void TestCase(int[] nums, int expected)
    {
        var solution = new Solution();
        int actual = solution.MinOperations(nums);

        if (actual != expected)
        {
            throw new Exception($"Expected {expected} for [{string.Join(", ", nums)}], but got {actual}.");
        }

        Console.WriteLine($"[{string.Join(", ", nums)}] -> {actual}");
    }

    public static void Main()
    {
        TestCase(new[] { 2, 10, 3 }, 2);
        TestCase(new[] { 1, 3, 5, 2 }, 3);
        TestCase(new[] { 0, 0, 0 }, 0);
        TestCase(new[] { -1, 5, 7 }, 3);
    }
}
