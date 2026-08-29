public class Program
{
    public static void Main(string[] args)
    {
        var result = MinOperations(new int[] { 5, 4, 3, 2, 1 }, 6);
        Console.WriteLine("Mininmum number of operations to make sum of array divisible by 6 is: " + result);
    }

    public static int MinOperations(int[] nums, int k)
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
        for (int i = nums.Length - 1; i >= 0; i--)
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