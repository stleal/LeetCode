public class MinOperationsSolution
{
  public int MinOperations(int[] nums, int k)
  {
    int sum = 0;
    int target = 0;
    int count = 0;
    Array.Sort(nums);
    for (int i = 0; i < nums.Length; i++)
    {
      sum += nums[i];
    }
    target = (sum / k) * k;
    for (int i = nums.Length-1; i >= 0; i--)
    {
      while (sum > target && nums[i] > 0)
      {
        nums[i] -= 1;
        sum -= 1;
        count++;
      }
      if (sum == target)
        return count;
    }
    return count;
  }
}