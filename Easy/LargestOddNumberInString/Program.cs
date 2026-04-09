public class Program
{

  public static void Main(string[] args)
  {
  }

    public string LargestOddNumberMine(string num) {
        long largestNumber = 0;
        for (int i = 0; i < num.Length; i++)
        {
        if (Convert.ToInt64(num.Substring(0, i+1)) % 2 == 1)
            largestNumber = Convert.ToInt64(num.Substring(0, i+1));
        }
        return (largestNumber != 0) ? largestNumber + "" : "";
    }

  public static string LargestOddNumber(string num)
  {
    for (int i = num.Length - 1; i >= 0; i--)
    {
      if ((num[i] - '0') % 2 == 1)
      {
        return num.Substring(0, i + 1);
      }
    }
    return "";
  }

}