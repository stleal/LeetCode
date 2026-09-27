public class Solution {
    public int[] ConcatWithReverse(int[] nums) {
        int count = 0;
        int[] ans = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++) 
        {
            ans[i] = nums[i];
            count++;
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            ans[count] = nums[i];
            count++;
        }
        return ans;
    }
}