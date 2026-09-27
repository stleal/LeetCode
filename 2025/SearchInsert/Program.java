/********************
 * Name: Samir Leal 
 * Date: 03/24/2023 
 *******************/
class Program
{
    public int searchInsert(int[] nums, int target)
    {
        
        // declare variables 
        int start; 
        int end; 
        int middle; 

        // initialize variables 
        start = 0; 
        end = nums.length - 1; 
        middle = -1; 

        // searches for target 
        while (start <= end) 
        {

            // binary search
            middle = (start + end) / 2; 

            if (nums[middle] == target) 
            {
                return middle; 
            }
            else if (nums[middle] < target) 
            {
                start = middle + 1; 
            }
            else if (nums[middle] > target) 
            {
                end = middle - 1; 
            }

        }

        // target was not found in the array
        if (nums[middle] > target) 
        {
            return middle; 
        }
        else 
        {
            return middle + 1; 
        }

    }

}