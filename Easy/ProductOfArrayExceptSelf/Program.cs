public class Program
{

  public static void Main(string[] args)
  {
    int[] nums = new int[] { 1, 2, 3, 4 };
    int[] result = ProductExceptSelf(nums);
    foreach (int i in result)
    {
      Console.WriteLine(i);
    }
  }

  public static int[] ProductExceptSelf(int[] nums)
  {
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
      result[i] = 1;
      for (int j = 0; j < nums.Length; j++)
      {
        if (i != j)
          result[i] *= nums[j];
      }
    }
    return result;
  }

}