/********************
 * Name: Samir Leal 
 * Date: 03/24/2023 
 *******************/

// Import Statements 
import java.util.ArrayList; 

class Solution
{
    public int removeElement(int[] nums, int val)
    {
        ArrayList<Integer> answer; 
        answer = new ArrayList<Integer>(); 
        for (int i = 0; i < nums.length; i++) 
        {
            if (nums[i] != val)
            {
                answer.add(nums[i]); 
            }
        }
        for (int i = 0; i < answer.size(); i++) 
        {
            nums[i] = answer.get(i); 
        }
        return answer.size(); 
    }
}
