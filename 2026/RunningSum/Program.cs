public class Program {
    public int[] RunningSum(int[] nums) {
        int[] runningSum = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                runningSum[i] += nums[j];
            }
        }
        return runningSum;
    }
}