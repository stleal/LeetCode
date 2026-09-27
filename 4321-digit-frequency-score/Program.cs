public class Program {
    public int DigitFrequencyScore(int n) {
        int num = n;
        int score = 0;        
        List<int> nums = new List<int>();
        List<int> cursor = new List<int>();
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;
            nums.Add(digit);
        }
        for (int i = 0; i < nums.Count(); i++)
        {
            if (!cursor.Contains(nums[i]))
            {
                int freq = nums.Count(x => x == nums[i]);
                score += freq * nums[i];
                cursor.Add(nums[i]);
            }
        }
        return score;
    }
}