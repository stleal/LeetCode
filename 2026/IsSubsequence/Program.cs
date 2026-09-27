public class Program {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0)
            return true;
        var index = 0;
        string subsequence = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            var found = false;
            for (int j = index; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    index = j+1;
                    subsequence += s[i];
                    found = true;
                    break;
                }
            }
            if (subsequence.Equals(s))
                return true;       
            if (!found)
                return false;
        }
        return subsequence.Equals(s);
    }
}