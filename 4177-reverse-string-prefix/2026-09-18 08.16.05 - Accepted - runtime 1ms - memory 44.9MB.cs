public class Solution {
    public string ReversePrefix(string s, int k) {
        var prefixArray = new string[k];
        for (int i = 0; i < k; i++)
        {
            prefixArray[i] = s[i].ToString();
        }
        Array.Reverse(prefixArray);
        var prefixReversed = "";
        for (int i = 0; i < prefixArray.Length; i++)
        {
            prefixReversed += prefixArray[i];
        }
        return (prefixReversed + s.Substring(k, s.Length-k));
    }
}