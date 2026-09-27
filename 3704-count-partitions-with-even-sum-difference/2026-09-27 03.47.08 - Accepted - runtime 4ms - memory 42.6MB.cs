public class Solution {
    public int CountPartitions(int[] nums) {
        var cursor = 0;
        var leftSum = 0;
        var rightSum = 0;
        var partitions = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j <= cursor; j++)
            {
                leftSum += nums[j];
            }
            for (int j = cursor + 1; j < nums.Length; j++)
            {
                rightSum += nums[j];
            }
            partitions += (leftSum - rightSum) % 2 == 0 ? 1 : 0;
            leftSum = 0;
            rightSum = 0;            
            cursor++;
        }
        return partitions;
    }
}