/********************
 * Name: Sam Leal
 * Date: 04/30/2023
 * Optimized: 09/26/2025
 *******************/
using System.Diagnostics;

public class Program
{
    public List<int> TargetIndices(int[] nums, int target)
    {
        List<int> result = new List<int>();

        // Count elements smaller than target and equal to target
        int smallerCount = 0;
        int targetCount = 0;

        foreach (int num in nums)
        {
            if (num < target)
                smallerCount++;
            else if (num == target)
                targetCount++;
        }

        // Generate target indices: they will be consecutive starting from smallerCount
        for (int i = 0; i < targetCount; i++)
        {
            result.Add(smallerCount + i);
        }

        return result;
    }
}