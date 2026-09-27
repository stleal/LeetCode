class Program
{
    private static final char[] VOWELS = {'a', 'e', 'i', 'o', 'u',
                                            'A', 'E', 'I', 'O', 'U'};
    public String reverseVowels(String s)
    {
        int top;
        char vowels[];
        String sReversed;
        int count;
        char vowelsReversed[];
        top = 0;
        sReversed = "";
        count = 0;
        // counts how many vowels there are
        for (int i = 0; i < s.length(); i++)
        {
            if (isVowel(s.charAt(i)))
            {
                count++;
            }
        }
        // initializes the vowels char arrays
        vowels = new char[count];
        vowelsReversed = new char[count];
        count = 0;
        // gets the vowels from the String
        for (int i = 0; i < s.length(); i++)
        {
           if (isVowel(s.charAt(i)))
           {
                vowels[count] = s.charAt(i);
                count++;
           }
        }
        count = 0;
        // reverses the vowels
        for (int i = vowels.length - 1; i >= 0; i--)
        {
            vowelsReversed[count] = vowels[i];
            count++;
        }
        // builds the reversed String
        for (int i = 0; i < s.length(); i++)
        {
            if (!isVowel(s.charAt(i)))
            {
                sReversed += s.charAt(i) + "";
            }
            else if (isVowel(s.charAt(i)))
            {
                sReversed += vowelsReversed[top];
                top++;
            }
        }
        return sReversed;
    }
    public static boolean isVowel(char x)
    {
        for (int i = 0; i < VOWELS.length; i++)
        {
            if (x == VOWELS[i])
            {
                return true;
            }
        }
        return false;
    }
}
