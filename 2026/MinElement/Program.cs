public class Program {
    public int MinElement(int[] nums) {
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