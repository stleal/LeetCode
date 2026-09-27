public class Program {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int count = 0;
        for (int i = 0; i < g.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (g[i] <= s[j])
                {
                    count++;
                    s[j] = -1;
                    break;
                }
            }
        }
        return count;
    }
}