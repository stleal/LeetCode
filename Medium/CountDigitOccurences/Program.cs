public class Program
{
    public static void Main(string[] args)
    {
      int[] nums = { 12, 54, 32, 22 };
      int digit = 2;
      Program p = new Program();
      int result = CountDigitOccurrences(nums, digit);
      Console.WriteLine(result);
    }
    public static int CountDigitOccurrences(int[] nums, int digit) {
        int count = 0;
        foreach (var num in nums)
        {
            int x = num;
            while (x > 0)
            {
                var q = x%10;
                if (q == digit)
                    count++;
                x/=10;
            }
        }
        return count;
    }
}