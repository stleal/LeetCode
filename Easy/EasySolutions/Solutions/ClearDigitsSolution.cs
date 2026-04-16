public class ClearDigitsSolution
{
  public string ClearDigits(string s)
  {
    var hasDigits = s.Any(char.IsDigit);
    while (hasDigits)
    {
      for (int i = 0; i < s.Length; i++)
      {
        if (char.IsDigit(s[i]) && i > 0)
        {
          s = s.Remove(i, 1);
          // previous left is now the current s[i]
          // check s[i] and remove if it's a digit
          if (i-1 >= 0 && !char.IsDigit(s[i-1]))
            s = s.Remove(i-1, 1);
            i= 0;
        }
      }
      hasDigits = s.Any(char.IsDigit);
    }
    return s;
  }
}