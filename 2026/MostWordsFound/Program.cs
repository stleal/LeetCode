public class Program {
    public int MostWordsFound(string[] sentences) {
        int maxNumberOfWords = 0;
        foreach (var sentence in sentences)
        {
            int size = sentence.Split().Count();
            maxNumberOfWords = size > maxNumberOfWords ? size : maxNumberOfWords;
        }
        return maxNumberOfWords;
    }
}