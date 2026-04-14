public class ScoreOfStringSolution
{
  public int ScoreOfString(string s)
  {
    int score = 0;
    int absDifference = 0;
    for (int i = 0; i < s.Length-1; i++)
    {
      absDifference = Math.Abs(s[i] - s[i+1]);
      score += absDifference;
    }
    return score;
  }
}