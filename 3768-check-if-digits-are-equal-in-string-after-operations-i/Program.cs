public class Program {
    public bool HasSameDigits(string s) {
      if (string.IsNullOrEmpty(s))
          return false;
      string current = s;
      while (current.Length > 1)
      {
          if (current.Length == 2)
              return current[0] == current[1];
          var next = new System.Text.StringBuilder(current.Length - 1);
          for (int i = 0; i < current.Length - 1; i++)
          {
              int sum = (current[i] - '0') + (current[i + 1] - '0');
              next.Append(sum % 10);
          }
          current = next.ToString();
      }
      return false;
    }
}