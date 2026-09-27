public class Program {
    public string[] FindRelativeRanks(int[] score) {
        int[] sortedScores = (int[])score.Clone();
        Array.Sort(sortedScores);
        Array.Reverse(sortedScores);
        Dictionary<int, string> ranksByScore = new Dictionary<int, string>(score.Length);
        for (int index = 0; index < sortedScores.Length; index++)
        {
            int place = index + 1;
            ranksByScore[sortedScores[index]] = place switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => place.ToString()
            };
        }
        string[] answer = new string[score.Length];
        for (int index = 0; index < score.Length; index++)
        {
            answer[index] = ranksByScore[score[index]];
        }
        return answer;
    }
}