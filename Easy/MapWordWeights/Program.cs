public class Program
{
    public static void Main(string[] args)
    {
        string[] words = new string[] { "abcd", "def", "xyz" };
        int[] weights = new int[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 };
        var result = MapWordWeights(words, weights);
        Console.WriteLine("Mapped word weights: " + result);
        words = new string[] { "light", "it", "up" };
        weights = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
        result = MapWordWeights(words, weights);
        Console.WriteLine("Mapped word weights: " + result);
    }

    public static string MapWordWeights(string[] words, int[] weights)
    {
        var index = 0;
        var result = string.Empty;
        int[] weightsReversed = new int[26];
        char[] alphabet = new char[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g',
            'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z'
        };

        for (int i = alphabet.Length - 1; i >= 0; i--)
        {
            weightsReversed[index++] = weights[i];
        }

        foreach (var word in words)
        {
            var sum = 0;
            var weight = 0;
            var letter = ' ';
            var sumModulo = 0;
            foreach (var ch in word)
            {
                weight = weightsReversed[alphabet.Length - 1 - Array.IndexOf(alphabet, ch)];
                sum += weight;
            }
            sumModulo = sum % alphabet.Length;
            letter = alphabet[alphabet.Length - 1 - sumModulo];
            result += letter;
        }

        return result;
    }
}
