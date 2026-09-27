/********************
 * Name: Sam Leal 
 * Date: 03/28/2023 
 *******************/
class Solution {

    // returns the square root of x 
    public int mySqrt(int x) {
        
        // declare variables 
        int start; int end; 
        int middle; int answer; 

        // initialize variables 
        start = 1; end = x; 
        middle = -1; answer = 0; 

        if (x == 0) 
        {
            return 0; 
        }

        while (start <= end) 
        {

            middle = (start + end) / 2; 

            if (x/middle == middle) 
            {
                return middle; 
            }
            else if (x/middle < middle) 
            {
                end = middle-1; 
            }
            else 
            {
                start = middle+1;
                answer = middle; 
            }

        }

        return answer; 

    }

}
