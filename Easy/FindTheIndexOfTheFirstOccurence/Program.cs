/********************
 * Name: Samir Leal 
 * Date: 03/24/2023 
 *******************/
 class Solution
 {
    public int strStr(String haystack, String needle)
    {
        if (haystack.length() < needle.length())
        {
            // if needle is longer than haystack, then 
            // return -1 
            return -1; 
        } 
        else if (haystack.length() == needle.length()) 
        {
            // if needle and haystack are both the same length, then 
            // check if needle matches haystack 
            if (haystack.equals(needle)) 
            {
                return 0;
            }
            else
            {
                return -1; 
            }
        }
        else
        {
            for (int i = 0; i <= haystack.length() - needle.length(); i++)
            {
                // check if needle is a substring of haystack 
                if (haystack.substring(i, i + needle.length()).equals(needle)) 
                {
                    // return the index where the substring was found 
                    return i; 
                }
            }
        }
        return -1; 
    }
}