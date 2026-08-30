public class Program
{
  public static void Main(string[] args)
  {
    int target = 2;
    int[] nums = { -1, 1, 2, 3, 1};
    var result = CountPairs(nums, target);
    Console.WriteLine(result);
  }

  public static int CountPairs(int[] nums, int target)
  {
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      for (int j = i + 1; j < nums.Length; j++)
      {
        if (nums[i] + nums[j] < target)
        {
          count++;
        }
      }
    }
    return count;
  }
}