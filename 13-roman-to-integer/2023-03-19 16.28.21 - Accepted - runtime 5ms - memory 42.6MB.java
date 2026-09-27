/********************
 * Name: Samir Leal 
 * Date: 03/19/2023 
 *******************/
class Solution 
{

    // Global Constants 
    public final char[] SYMBOLS = new char[] {'I', 'V', 'X', 'L', 'C', 'D', 'M'}; 
    public final int[] VALUES = new int[] {1, 5, 10, 50, 100, 500, 1000}; 
    
    // converts a Roman number into an Integer
    public int romanToInt(String s) 
    {

        // declare variables 
        int sum; 
        char c; 
        char c2; 
        int value; 
        int nextValue; 

        // initialize variables 
        sum = 0; 
        c = ' '; 
        c2 = ' '; 
        value = 0; 
        nextValue = 0; 

        // converts the Roman number into an Integer
        for (int i = 0; i < s.length(); i++) 
        {
            c = s.charAt(i); 
            value = getValueOfSymbol(c); 
            if (i < s.length() - 1) 
            {
                c2 = s.charAt(i+1); 
                nextValue = getValueOfSymbol(c2); 
                if (nextValue > value) 
                {
                    sum += (nextValue - value); 
                    i++;                
                }
                else
                {
                    sum += value;                
                }           
            }
            else 
            {
                if (i == s.length()-1) 
                {
                    c = s.charAt(s.length()-1); 
                    value = getValueOfSymbol(c); 
                    sum += value;               
                }                         
            }
        }

        // returns the answer 
        return sum; 

    }

    public int getValueOfSymbol(char c) 
    {
        for (int i = 0; i < SYMBOLS.length; i++) 
        {
            if (SYMBOLS[i] == c) 
            {
                return VALUES[i]; 
            }
        }
        return -1; 
    }

}
