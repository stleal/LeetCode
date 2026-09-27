/********************
 * Name: Sam Leal 
 * Date: 04/29/2023 
 *******************/
 class Solution
{
    public String sortSentence(String s)
    {
        String[] words; 
        int[] indices; 
        Object swap; 
        String sentence; 

        words = s.split(" "); 
        indices = new int[words.length]; 
        swap = null; 
        sentence = ""; 
        
        for (int i = 0; i < words.length; i++) 
        {
            indices[i] = Character.digit(words[i].charAt(words[i].length()-1), 10); 
        }

        for (int i = 0; i < indices.length; i++) 
        {
            for (int j = 0; j < indices.length-1; j++) 
            {
                if (indices[i] < indices[j]) 
                {
                    
                    swap = indices[j]; 
                    indices[j] = indices[i]; 
                    indices[i] = (int) swap; 

                    swap = words[j]; 
                    words[j] = words[i]; 
                    words[i] = (String) swap; 

                }
            }
        }

        for (int i = 0; i < words.length-1; i++) 
        {
            sentence += words[i].substring(0, words[i].length()-1) + " "; 
        }

        return sentence + words[words.length-1].substring(0, words[words.length-1].length()-1); 

    }

}
