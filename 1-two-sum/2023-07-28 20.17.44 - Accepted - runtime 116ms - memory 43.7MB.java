/********************
 * Name: Samir Leal 
 * Date: 03/19/2023 
 *******************/
class Solution
{
    public int[] twoSum(int[] nums, int target)
    {
        int sum; 
        int[] answer; 
        sum = 0; 
        answer = new int[2]; 
        for (int i = 0; i < nums.length; i++) 
        {
            sum = nums[i]; 
            for (int j = 0; j < nums.length; j++) 
            {
                if (j != i) 
                {
                    sum += nums[j]; 
                    if (sum == target) 
                    {
                        answer[0] = i; 
                        answer[1] = j; 
                        return answer; 
                    }
                    else 
                    {
                        sum = nums[i]; 
                    }                    
                }
            }
        }
        return answer; 
    }
}