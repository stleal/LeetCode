public class Program {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int n = nums.Length;
        int[] answer = new int[n];
        
        // Step 1: Fill answer[] with prefix products (all elements to the left)
        int prefix = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        
        // Step 2: Multiply by suffix products (all elements to the right)
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
        }
        
        return answer;
    }
}