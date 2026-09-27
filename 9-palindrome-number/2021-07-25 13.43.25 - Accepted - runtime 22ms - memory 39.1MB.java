class Solution 
{
    
    public boolean isPalindrome(int x) 
    {
        
        String s; 
        String s2; 
        boolean isPalindrome; 
        
        s = x + ""; 
        s2 = ""; 
        for (int i = s.length() - 1; i >= 0; i--) 
        {
            
            s2 += s.charAt(i); 
            
        }
        
        return s.equals(s2); 
        
    }
    
}