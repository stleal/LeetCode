public class Program {
    public IList<int> FindWordsContaining(string[] words, char x) {
        int index = 0;
        IList<int> indices = new List<int>();
        foreach (var word in words) {
            if (word.Contains(x))
                indices.Add(index);
            index++;
        }
        return indices;
    }
}