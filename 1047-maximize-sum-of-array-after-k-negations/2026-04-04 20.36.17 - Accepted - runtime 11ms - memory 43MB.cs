public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        // 1. determine how many negative numbers there are in the array
        var negativeCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
        if (nums[i] < 0)
            negativeCount++;
        }
        // 2. if there are more negative numbers than k, then we can only negate k of them
        // negate the k smallest negative numbers
        var availableRepitiions = (k >= negativeCount) ? negativeCount : k;
        for (int i = 0; i < availableRepitiions; i++)
        {
        nums[i] = -nums[i];
        }
        var remaindingRepitions = k - negativeCount;
        Array.Sort(nums);
        var indexOfSmallestNumber = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                indexOfSmallestNumber = i;
                break;
            }
        }
        for (int i = 0; i < remaindingRepitions; i++)
        {
            nums[indexOfSmallestNumber] = -nums[indexOfSmallestNumber];
        }
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
        sum += nums[i];
        }
        return sum;
    }

    public static int[] BubbleSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[i] < nums[j])
                {
                int local = nums[i];
                nums[i] = nums[j];
                nums[j] = local;
                }
            }
        }
        return nums;
    }
}