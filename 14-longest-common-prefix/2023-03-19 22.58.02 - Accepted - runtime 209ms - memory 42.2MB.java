/********************
 * Name: Samir Leal 
 * Date: 03/19/2023 
 *******************/
class Solution 
{

    // finds the longest common prefix string amongst an array of strings
    public String longestCommonPrefix(String[] strs)
    {

        // declare variables 
        String element;  
        String substring; 
        String longestCommonPrefix; 

        // initialize variables 
        element = ""; 
        substring = ""; 
        longestCommonPrefix = ""; 

        // if there's only 1 element in the array 
        if (strs.length == 1) 
        {
            return strs[0];
        }

        /*******************************************************
        * gets the next element from the strs array and checks 
        * each substring with the other elements in the array 
        *******************************************************/
        for (int i = 0; i < strs.length; i++) 
        {
            element = strs[i]; 
            if (element.length() == 0) 
            {
                return ""; 
            }
            for (int j = 1; j <= element.length(); j++) 
            {
                substring = element.substring(0, j); 
                for (int k = 0; k < strs.length; k++) 
                {
                    if (substring.length() <= strs[k].length()) 
                    {
                        if (!(substring.equals(strs[k].substring(0, j)))) 
                        {
                            // returns the longest common prefix string amongst the array of strings
                            return longestCommonPrefix; 
                        }
                    } 
                    else 
                    {
                        return longestCommonPrefix; 
                    }
                }
                longestCommonPrefix = element.substring(0, j); 
            }
        }
        
        // returns the longest common prefix
        return longestCommonPrefix; 
        
    }

}
