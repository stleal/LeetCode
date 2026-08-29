/*************************************************************************************************
 * You are given a string `s` consisting of lowercase English letters (`'a'` to `'z'`).
 *
 * Your task is to:
 *
 * - Find the vowel (one of `'a'`, `'e'`, `'i'`, `'o'`, or `'u'`) with the **maximum** frequency.
 * - Find the consonant (all other letters excluding vowels) with the **maximum** frequency.
 * Return the sum of the two frequencies.
 *
 * **Note**: If multiple vowels or consonants have the same maximum frequency, you may choose any one of them.
 * If there are no vowels or no consonants in the string, consider their frequency as 0.
 *
 * The **frequency** of a letter `x` is the number of times it occurs in the string.
 ************************************************************************************************/
public class Program
{
    public static void Main(string[] args)
    {
        var result = MaxFreqSum("abbbccc");
        Console.WriteLine("Max freq sum: " + result);
    }

    public static int MaxFreqSum(string s)
    {
        var vowelsMax = 0;
        var consonantsMax = 0;
        Dictionary<char, int> vowels = new Dictionary<char, int>();
        Dictionary<char, int> consonants = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (IsVowel(c))
            {
                if (vowels.ContainsKey(c))
                    vowels[c]++;
                if (!vowels.ContainsKey(c))
                    vowels.Add(c, 1);
            }
            else
            {
                if (consonants.ContainsKey(c))
                    consonants[c]++;
                if (!consonants.ContainsKey(c))
                    consonants.Add(c, 1);
            }
        }

        vowelsMax = (vowels.Count > 0) ? vowels.Values.Max() : 0;
        consonantsMax = (consonants.Count > 0) ? consonants.Values.Max() : 0;
        return vowelsMax + consonantsMax;
    }

    private static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
