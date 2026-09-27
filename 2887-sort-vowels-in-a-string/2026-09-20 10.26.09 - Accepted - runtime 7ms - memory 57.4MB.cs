public class Solution {
    public string SortVowels(string s) {
        char[] result = s.ToCharArray();
        int[] vowelCounts = new int[128];
        char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                vowelCounts[s[i]]++;
            }
        }
        int vowelIndex = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (!IsVowel(result[i]))
                continue;

            while (vowelCounts[vowels[vowelIndex]] == 0)
                vowelIndex++;

            result[i] = vowels[vowelIndex];
            vowelCounts[vowels[vowelIndex]]--;
        }
        return new string(result);
    }
    public bool IsVowel(char s)
    {
        return s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u'
            || s == 'A' || s == 'E' || s == 'I' || s == 'O' || s == 'U';
    }
}