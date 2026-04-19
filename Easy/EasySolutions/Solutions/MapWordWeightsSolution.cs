public class MapWordWeightsSolution {
    public string MapWordWeights(string[] words, int[] weights) {
        var index = 0;
        var result = string.Empty;
        int[] weightsReversed = new int[26];
        char[] alphabet = new char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g',
            'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z'
        };
        for (int i = alphabet.Length-1; i >= 0; i--)
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
                weight = weightsReversed[alphabet.Length-1 - Array.IndexOf(alphabet, ch)];
                sum += weight;
            }
            sumModulo = sum % alphabet.Length;
            letter = alphabet[alphabet.Length-1 - sumModulo];
            result += letter;
        }
        return result;
    }
}