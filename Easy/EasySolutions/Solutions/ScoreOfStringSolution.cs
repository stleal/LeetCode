public class ScoreOfStringSolution
{
  public int ScoreOfString(string s)
  {
    var score = 0;
    for (int i = 0; i < s.Length-1; i++)
    {
      var absDifference = Math.Abs(s[i] - s[i+1]);
      score += absDifference;
    }
    return score;
  }
}