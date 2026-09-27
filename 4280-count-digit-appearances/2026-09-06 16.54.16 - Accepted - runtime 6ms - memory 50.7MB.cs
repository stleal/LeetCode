public class Solution {
    public int CountDigitOccurrences(int[] nums, int digit) {
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