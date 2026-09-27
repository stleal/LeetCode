class Program 
{
    
    public ArrayList<Integer> data; 
    
    /** Initialize your data structure here. */
    public RandomizedCollection() 
    {
        
        data = new ArrayList<Integer>(); 
        
    }
    
    /** Inserts a value to the collection. Returns true if the collection 
     * did not already contain the specified element. */
    public boolean insert(int val) 
    {
        
        boolean found; 
        
        found = false; 
        
        // checks to see if the number is already in the ArrayList<Integer> 
        while (!found) 
        {
            
            // if, it is already in the ArrayList<Integer>, then return false 
            for (int i = 0; i < data.size(); i++) 
            {
                
                // inserts the number to the ArrayList<Integer> 
                if (val == data.get(i)) 
                {
                    
                    data.add(val); 
                    found = true; 
                    return false; 
                    
                }
                
            }
            
            // if, it's not found, then insert it anyway and return true 
            if (!found) 
            {
                
                data.add(val); 
                return true; 
                
            }
            
        }
        
        return false; 
        
    }
    
    /** Removes a value from the collection. Returns true if the collection 
     * contained the specified element. */
    public boolean remove(int val) 
    {
        
        boolean found; 
        int index; 
        
        found = false; 
        index = -1; 
        
        // checks if the number is in the ArrayList<Integer> 
        while (!found) 
        {
            
            for (int i = 0; i < data.size(); i++) 
            {
                
                if (val == data.get(i)) 
                {
                    
                    index = i; 
                    data.remove(index); 
                    found = true; 
                    return true; 
                    
                }
                
            }
            
            if (!found) 
            {
                
                break; 
                
            }
            
        }
        
        return false; 
    }
    
    /** Get a random element from the collection. */
    public int getRandom() 
    {
        
        int index; 
        
        index = -1; 
        
        index = (int) (Math.random() * data.size()) + 0; 
        
        return data.get(index); 
        
    }
    
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * boolean param_1 = obj.insert(val);
 * boolean param_2 = obj.remove(val);
 * int param_3 = obj.getRandom();
 */