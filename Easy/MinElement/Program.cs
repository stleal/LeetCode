public class Program {
  public static void Main(string[] args)
  {
    var answer = MinElement([10, 12, 13, 14]);
    Console.WriteLine(answer);
    answer = MinElement([1, 2, 3, 4]);
    Console.WriteLine(answer);
    answer = MinElement([999, 19, 199]);
    Console.WriteLine(answer);
  }

  public static int MinElement(int[] nums) {
      int[] sumOfDigits = new int[nums.Length];
      for (int i = 0; i < nums.Length; i++)
      {
          int x = nums[i];
          int sum = 0;
          while (x > 0)
          {
              sum += x % 10;
              x /= 10;
          }
          sumOfDigits[i] = sum;
      }
      int min = sumOfDigits[0];
      for (int i = 1; i < sumOfDigits.Length; i++)
      {
          min = (sumOfDigits[i] < min) ? sumOfDigits[i] : min;
      }
      return min;
  }

  public static int MinElementOptimized(int[] nums)
  {
      int min = int.MaxValue;
      for (int i = 0; i < nums.Length; i++)
      {
          int x = nums[i];
          int sum = 0;
          while (x > 0)
          {
              sum += x % 10;
              x /= 10;
          }
              min = Math.Min(min, sum);
      }
      return min;
  }
}