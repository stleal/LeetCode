/******************************************************************************************************************
 * Name: Sam Leal
 * Date: 04/03/2024
 * Description: Given an array of integers nums and an integer k, modify the array in the following way:
 * choose an index i and replace nums[i] with -nums[i], and repeat this process exactly k times. You may choose
 * the same index i multiple times. Return the largest possible sum of the array after modifying it in this way.
 *
 * Example 1:
 * Input: nums = [4,2,3], k = 1
 * Output: 5
 * Explanation: Choose index 1 and nums becomes [4,-2,3].
 *
 * Example 2:
 * Input: nums = [3,-1,0,2], k = 3
 * Output: 6
 * Explanation: Choose indices (1, 2, 2) and nums becomes [3,1,0,2].
 *
 * Example 3:
 * Input: nums = [2,-3,-1,5,-4], k = 2
 * Output: 13
 * Explanation: Choose indices (0, 4) and nums becomes [-2,-3,-1,5,4].
*****************************************************************************************************************/
public class Program
{
  public static void Main(string[] args)
  {
    int k = 3;
    int[] nums = [-2,5,0,2,-2];
    var largestSum = LargestSumAfterKNegations(nums, k);
    Console.WriteLine(largestSum);
  }

  public static int LargestSumAfterKNegations(int[] nums, int k)
  {
    BubbleSort(nums);
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
    // 3. re-sort the array and negate the smallest number if there are remaining repitiions
    BubbleSort(nums);
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
    // 4. get the sum of the array and return it
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