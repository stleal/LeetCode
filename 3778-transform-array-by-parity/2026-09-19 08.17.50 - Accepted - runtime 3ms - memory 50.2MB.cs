public class Solution {
    public int[] TransformArray(int[] nums) {
        int[] numsTransformed = new int[nums.Length];
        nums.CopyTo(numsTransformed);
        for (int i = 0; i < numsTransformed.Length; i++)
        {
            numsTransformed[i] = (numsTransformed[i]%2==0) ? 0 : 1;
        }
        Array.Sort(numsTransformed);
        return numsTransformed;
    }
}