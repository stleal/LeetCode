/********************
 * Name: Samir Leal 
 * Date: 03/22/2023 
 *******************/

 // Import Statements 
import java.util.ArrayList; 

// Removes Duplicates from a Sorted Array 
 class Program {

    // Remove Duplicates from Sorted Array 
    public int removeDuplicates(int[] nums) {
        
        // declare variables 
        int k; 
        ArrayList<Integer> answer; 

        // initialize variables 
        k = 0; 
        answer = new ArrayList<Integer>(); 

        // copies nums without any duplicates into answer 
        for (int i = 0; i < nums.length; i++) 
        {
            if (!answer.contains(nums[i]))
            {
                answer.add(nums[i]); 
            }
        }

        // gets the size of k 
        k = answer.size(); 

        // replaces the values in nums with the answer 
        for (int i = 0; i < k; i++) 
        {
            nums[i] = answer.get(i); 
        }

        // returns k
        return k; 

    }

}
