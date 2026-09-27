/********************
 * Name: Sam Leal 
 * Date: 04/02/2023 
 *******************/

// Import Statements 
import java.util.ArrayList; 
import java.util.HashMap; 

class Solution {

    // determines if the input string is valid
    public boolean isValid(String s) {
        
        // declare variables 
        char c; int counter; 
        ArrayList<Character> closingBrackets; 
        HashMap<Character, Character> bracketMap; 
        boolean flag; 

        // initialize variables 
        c = s.charAt(s.length()-1); counter = 0; 
        closingBrackets = new ArrayList<Character>(); 
        bracketMap = new HashMap<Character, Character>();
        bracketMap.put(')', '('); 
        bracketMap.put('}', '{'); 
        bracketMap.put(']', '['); 
        flag = false; 

        // check the very last character and additional special cases 
        if (c == '(' || c == '{' || c == '[' || s.length() == 1 || s.length() % 2 == 1)  
        {
            // return false if it's an opening bracket 
            return false; 
        }

        // check the remaining characters 
        for (int i = s.length()-2; i >= 0; i--) 
        {

            if (s.charAt(i) == ')' || s.charAt(i) == '}' || s.charAt(i) == ']')
            {

                // adds the current closing bracket to the list 
                closingBrackets.add(c);
                
                // increments our counter variable 
                counter++; 

                // gets the next character 
                c = s.charAt(i); 

            }
            else 
            {

                // check if the next char is the corresponding open bracket of the same type 
                if (c != ' ' && !(s.charAt(i) == bracketMap.get(c))) 
                {
                    flag = true; 
                    break; 
                }
                else if (c == ' ' && (s.charAt(i) == '(' || s.charAt(i) == '{' || s.charAt(i) == '[')) 
                {
                    flag = true; 
                    break; 
                }
                else
                {

                    // found a matching pair of opening and closing brackets 
                    if (counter >= 1) 
                    {

                        // get the previous closing bracket from the list 
                        c = closingBrackets.get(counter-1); 

                        // remove the current closing bracket from the list 
                        closingBrackets.remove(counter-1); 

                        // decrement our counter variable 
                        counter--; 

                    } 
                    else if (counter == 0) 
                    {
                        c = ' '; 
                    }

                }

            }

        }

        // check if counter is greater than zero 
        if (counter > 0) 
        {
            return false; 
        }

        // returns the opposite/negation of flag 
        return !flag; 

    }   

}
