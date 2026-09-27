public class Solution {
    public int AlternatingSum(int[] nums) {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += (i%2==0) ? nums[i] : nums[i] * -1;
        }
        return sum;
    }
}