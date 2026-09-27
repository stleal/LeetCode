public class Program {
    public int MinimumOperations(int[] nums) 
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int target = FindClosestDivisor(nums[i]);
            count += Math.Abs(target - nums[i]);
        }
        return count;
    }
    public int FindClosestDivisor(int n)
    {
        int remainder = ((n % 3) + 3) % 3;
        if (remainder == 0)
            return n;
        if (remainder == 1)
            return n - 1;   // closer than n + 2
        return n + 1;
    }
}