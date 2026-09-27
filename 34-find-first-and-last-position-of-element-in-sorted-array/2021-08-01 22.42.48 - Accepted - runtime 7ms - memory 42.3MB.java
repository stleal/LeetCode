class Solution 
{
    
    public int[] searchRange(int[] nums, int target) 
    {
        
        int[] range; 
        int start, end; 
        
        range = new int[2]; 
        start = -1; end = -1; 
        
        // gets the starting index 
        for (int i = 0; i < nums.length; i++) 
        {
            
            if (nums[i] == target)
            { 
                
                start = i; 
                break; 
                
            } 
            
        } 
        
        if (start != -1) 
        {
        
            // gets the ending index 
            for (int i = start; i < nums.length; i++) 
            {

                if (nums[i] == target) 
                {

                    end = i; 

                }

            } 
            
        }
        
        System.out.println("Start: " + start); 
        System.out.println("End: " + end); 
        
        range[0] = start; 
        range[1] = end; 
        
        return range; 
        
    }
    
}
