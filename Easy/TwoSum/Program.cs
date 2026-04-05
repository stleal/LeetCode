/********************
 * Name: Samir Leal
 * Date: 03/19/2023
 * Optimized: 09/25/2025 - O(n) hash map solution
 *******************/
class Solution
{
    public int[] twoSum(int[] nums, int target)
    {
        // Dictionary to store number -> index mapping
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if complement exists in the map
            if (numMap.ContainsKey(complement))
            {
                // Found the pair! Return indices
                return new int[] { numMap[complement], i };
            }

            // Add current number and its index to the map
            // Use indexer with check to handle duplicate values
            if (!numMap.ContainsKey(nums[i]))
            {
                numMap[nums[i]] = i;
            }
        }

        // No solution found (though problem guarantees one exists)
        return new int[0];
    }
}
