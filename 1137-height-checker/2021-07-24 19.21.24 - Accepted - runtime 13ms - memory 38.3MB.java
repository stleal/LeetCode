class Solution 
{
    
    public int heightChecker(int[] heights) 
    {
        
        int count;
        int heightsSorted[]; 
        int local;  
        
        count = 0; 
        heightsSorted = new int[heights.length]; 
        local = -1; 
        
        // copies the array 
        for (int i = 0; i < heights.length; i++) 
        {
            
            heightsSorted[i] = heights[i]; 
            
        }
        
        // sorts the array 
        for (int i = 0; i < heightsSorted.length; i++) 
        {
            
            for (int j = 0; j < heightsSorted.length - 1; j++) 
            {
                
                if (heightsSorted[j] > heightsSorted[j+1]) 
                {
                    
                    // swaps the two values 
                    local = heightsSorted[j]; 
                    heightsSorted[j] = heightsSorted[j+1]; 
                    heightsSorted[j+1] = local; 
                    
                }
                
            }
            
        }
        
        System.out.println("Heights: " + Arrays.toString(heights)); 
        System.out.println("Expected: " + Arrays.toString(heightsSorted)); 
        
        for (int i = 0; i < heights.length; i++) 
        {
            
            if (heights[i] != heightsSorted[i]) 
            {
                
                count++; 
                
            }
            
        }
        
        System.out.println("Count: " + count); 
        
        return count; 
        
    }
    
}