/********************
 * Name: Sam Leal 
 * Date: 03/26/2023 
 *******************/
 class Program
{

    // returns the sum of two binary strings 
    public String addBinary(String a, String b)
    {
        
        // declare variables 
        int i; int j; 
        int carry; int sum; 
        StringBuilder result; 

        // initialize variables 
        i = a.length() - 1; 
        j = b.length() - 1; 
        carry = 0; sum = 0; 
        result = new StringBuilder(); 
        
        // adds the two binary strings together 
        while (i >= 0 || j >= 0 || carry == 1) 
        {
            sum = carry; 
            if (i >= 0) 
            {
                sum = sum + a.charAt(i) - '0'; 
            }
            if (j >= 0) 
            {
                sum = sum + b.charAt(j) - '0'; 
            }
            result.append((char)(sum % 2 + '0')); 
            carry = sum/2; 
            i--; 
            j--; 
        }

        // returns result 
        return result.reverse().toString(); 

    }

}
