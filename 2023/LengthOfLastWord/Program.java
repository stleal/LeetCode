/********************
 * Name: Sam Leal 
 * Date: 03/24/2023 
 *******************/
class Program
{
    public int lengthOfLastWord(String s)
    {
        String[] words; 
        words = s.split(" "); 
        return words[words.length-1].length(); 
    }
}