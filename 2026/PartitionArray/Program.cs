public class Program {
    public int PartitionArray(int[] nums, int k) {
        if (nums.Length == 0)
        {
            return 0;
        }
        Array.Sort(nums);
        int subsequenceCount = 1;
        int currentMinimum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if ((long)nums[i] - currentMinimum > k)
            {
                subsequenceCount++;
                currentMinimum = nums[i];
            }
        }
        return subsequenceCount;
    }
}