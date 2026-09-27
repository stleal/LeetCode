class Solution 
{
    
    public int reverse(int x) 
    {
        
        int q, y; 
        long xReversed; 
        String s; 
        boolean negative; 

        q = -1; y = 0; 
        xReversed = 0; 
        s = ""; 
        negative = false; 

        if (x < 0) 
        {
            
            x *= -1; 
            negative = true; 
            
        }
        
        if (x == 0 || x == Integer.MAX_VALUE || x == Integer.MIN_VALUE) 
        {
            
            return 0; 
            
        }
        
        // reverses the Integer, x 
        while (x > 0) 
        {

            q = (x % 10); 
            s += q; 
            x /= 10; 

        }

        // converts the Integer, back into an int, from a String 
        xReversed = Long.parseLong(s); 

        if (xReversed > Integer.MAX_VALUE || xReversed < Integer.MIN_VALUE)  
        {
            
            return 0; 
            
        }
        
        if (negative) 
        {
            
            xReversed *= -1; 
            
        }
        
        y = (int) xReversed; 
        
        // returns the Integer x, reversed 
        return y; 
        
    }
    
}