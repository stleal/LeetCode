public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string w1 = "";
        foreach (var substring in word1)
        {
            w1+=substring;
        }
        string w2 = "";        
        foreach (var substring in word2)
        {
            w2+=substring;
        }
        return w1.Equals(w2);
    }
}