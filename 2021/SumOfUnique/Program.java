class Program 
{
    
    public int sumOfUnique(int[] nums) 
    {
        
        // declares our local variables 
        int sum;    
        ArrayList<Integer> elements; 
        ArrayList<Integer> count, uniqueElements; 
        boolean found; 
        
        // initializes our local variables 
        sum = -1;
        elements = new ArrayList<Integer>(); 
        count = new ArrayList<Integer>(); 
        uniqueElements = new ArrayList<Integer>(); 
        found = false; 
        
        // re-instantiates our local variables 
        sum = 0; 
        
        /********************
         * Loops through each number in nums int[].  
         * 1. removes the duplicates from nums int[], and saves the new array  
         * into elements ArrayList<Integer>, but doesn't modify nums. 
         * 2. counts the number of occurrences of each number. 
         * 3. only those numbers that appear, once, are saved into 
         * uniqueElements ArrayList<Integer>. 
         */
        for (int i = 0; i < nums.length; i++) 
        {
            
            // checks to see if the number is already in elements ArrayList 
            while (!found) 
            {
                
                // if, it finds the number 
                for (int j = 0; j < elements.size(); j++) 
                {
                   
                    // then, it updates the counter (+1) 
                    if (nums[i] == elements.get(j)) 
                    {
                        
                        // updates the counter 
                        count.set(j, count.get(j) + 1); 
                        found = true; 
                        break; 
                        
                    }
                }
                
                // if, the number is not found, then it adds it to elements 
                if (!found) 
                {

                    elements.add(nums[i]); 
                    count.add(0); 

                }
            
            }

            // sets found equal to false, again for the next number 
            found = false; 
            
        }
        
        // saves the unique elements into uniqueElements ArrayList<Integer> 
        for (int i = 0; i < count.size(); i++) 
        {
            
            if (count.get(i) == 1) 
            {
                
                uniqueElements.add(elements.get(i)); 
                
            }
            
        }
        
        // calculates the sum of the unique elements 
        for (int i = 0; i < uniqueElements.size(); i++) 
        {
            
            sum += uniqueElements.get(i); 
            
        }
        
        // returns the sum of all unique numbers 
        return sum; 
        
    }
    
}