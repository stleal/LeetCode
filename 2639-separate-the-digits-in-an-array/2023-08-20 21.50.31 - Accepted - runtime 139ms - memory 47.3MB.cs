/*********************************
 * Name: Samir Leal 
 * Date: 08/20/2023 
 * ******************************/
public class Solution {

    public int[] SeparateDigits(int[] nums) {

        // declare local variables 
        string s;
        int[] answer;
        int size, counter;

        // initialize local variables 
        size = 0;
        counter = 0; 

        // counts the number of digits in each number in the int array 
        for (int i = 0; i < nums.Length; i++)
        {
            s = nums[i].ToString(); 
            size += s.Length; 
        }

        // initialize our answer array 
        answer = new int[size]; 

        // loop through each number in the integer array and extract the digits 
        for (int i = 0; i < nums.Length; i++)
        {
            s = nums[i].ToString(); 
            for (int j = 0; j < s.Length; j++)
            {
                answer[counter] = (int)Char.GetNumericValue(s.ElementAt(j)); 
                counter++; 
            }
        }

        // return answer 
        return answer; 

    }

}
