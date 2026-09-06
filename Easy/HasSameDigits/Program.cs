using System.Text;

public class Program {
  public static void Main(string[] args)
  {
    var answer = HasSameDigits("3902");
    Console.WriteLine(answer);
    answer = HasSameDigits("34789");
    Console.WriteLine(answer);
  }

  public static bool HasSameDigits(string s) {
      string x = s;
      string y = "";
      while (x.Length >= 2)
      {
          while (x.Length >= 2)
          {
              int x1 = Convert.ToInt32(x.Substring(0, 1));
              int x2 = Convert.ToInt32(x.Substring(1, 1));
              int sum = (x1 + x2) % 10;
              y += sum;
              x = x.Substring(1, x.Length-1);
          }
          x = y;
          y = "";
      }
      int ans = Convert.ToInt32(x);
      return (ans/10 == ans%10) ? true : false;
  }

  public static bool HasSameDigitsOptimized(string s)
  {
      if (string.IsNullOrEmpty(s))
          return false;
      string current = s;
      while (current.Length > 1)
      {
          if (current.Length == 2)
              return current[0] == current[1];
          var next = new StringBuilder(current.Length - 1);
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