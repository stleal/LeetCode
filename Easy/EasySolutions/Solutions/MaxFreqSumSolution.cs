public class MaxFreqSumSolution
{
  public int MaxFreqSum(string s)
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

  private bool IsVowel(char c)
  {
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
  }
}