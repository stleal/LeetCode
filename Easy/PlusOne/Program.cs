/********************
 * Name: Sam Leal
 * Date: 03/25/2023
 *******************/
class Solution
{
    public int[] plusOne(int[] digits)
    {
        // check if the last digit is less than or equal to 9
        if (digits[digits.length-1] < 9)
        {
            digits[digits.length-1] += 1;
            return digits;
        }
        else if (digits[digits.length-1] == 9)
        {
            // special case where length equals 1
            if (digits.length == 1)
                return new int[]{1, 0};
            // builds a new array
            digits[digits.length-1] += 1;
            for (int i = digits.length-1; i >= 0; i--)
            {
                if (digits[i] == 10 && i >= 1)
                {
                    digits[i] = 0;
                    digits[i-1] += 1;
                }
                else if (digits[i] == 10 && i == 0)
                {
                    int[] answer;
                    answer = new int[digits.length+1];
                    for (int j = 0; j < digits.length; j++)
                    {
                        answer[j] = digits[j];
                    }
                    answer[0] = 1;
                    return answer;
                }
            }
            // returns digits incremented by 1
            return digits;
        }
        // return a new int array
        return new int[0];
    }
}
