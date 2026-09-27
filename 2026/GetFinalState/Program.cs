public class Program {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int index = 0;
        int count = 0;
        int[] result = new int[nums.Length];
        nums.CopyTo(result);
        while (count < k)
        {
            index = FindMin(result);
            result[index] *= multiplier;
            count++;
        }
        return result;
    }
    public int FindMin(int[] nums)
    {
        int index = 0;
        int min = nums[index];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[index]) 
            {
                min = nums[i]; 
                index = i;
            }
        }
        return index;
    }
}