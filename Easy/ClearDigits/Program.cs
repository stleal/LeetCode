public class Program
{
    public static void Main(string[] args)
    {
        string s = "li5i56";
        var result = ClearDigits(s);
        Console.WriteLine("String after clearing digits: " + result);
    }

    public static string ClearDigits(string s)
    {
        var hasDigits = s.Any(char.IsDigit);
        while (hasDigits)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) && i > 0)
                {
                    s = s.Remove(i, 1);
                    if (i - 1 >= 0 && !char.IsDigit(s[i - 1]))
                    {
                        s = s.Remove(i - 1, 1);
                        i = 0;
                    }
                }
            }
            hasDigits = s.Any(char.IsDigit);
        }
        return s;
    }
}
