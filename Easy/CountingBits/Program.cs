/***************************************************************************************************************************
 * Name: Mr. Sam Leal
 * Date: 04/03/2026
 * Description: Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the
 * number of 1's in the binary representation of i.
 **************************************************************************************************************************/
public class Program
{
  public static void Main(string[] args)
  {
    var result = CountBits(7);
  }

  // 1. add 1 to n
  // 2. iterate from 0 to n and convert each number to binary and count the number of 1's
  // 3. return the result as an array
  private static object CountBits(int n)
  {
    var num = n + 1;
    int[] ans = new int[num];
    for (int i = 0; i < num; i++)
    {
      var binary = ConvertToBinaryFinal(i);
      var count = binary.Count(x => x == '1');
      ans[i] = count;
    }
    return ans;
  }

  private static string ConvertToBinarySuggested(int num)
  {
    var sum = 0;
    var result = string.Empty;
    var logBase = (int)Math.Log(num, 2);
    var numberOfBits = logBase + 1;
    for (int i = numberOfBits-1; i >=0; i--)
    {
      var x = Math.Pow(2, i);
      result = (!(sum + x > num)) ? result + "1" : result + "0";
      sum += (result[result.Length - 1].Equals("1")) ? (int)x : 0;
    }
    return result;
  }

  private static string ConvertToBinaryFinal(int num)
  {
    var sum = 0;
    var result = string.Empty;
    var logBase = (int)Math.Log(num, 2);
    var numberOfBits = logBase + 1;
    for (int i = numberOfBits-1; i >=0; i--)
    {
      var x = Math.Pow(2, i);
      result = (!(sum + x > num)) ? result + "1" : result + "0";
      sum += (IsLastCharOne(result)) ? (int)x : 0;
    }
    return result;
  }

  private static bool IsLastCharOne(string result)
  {
    return result[result.Length - 1] == '1';
  }

  private static string ConvertToBinary(int num)
  {
    var sum = 0;
    var result = string.Empty;
    var logBase = (int)Math.Log(num, 2);
    var numberOfBits = logBase + 1;
    for (int i = numberOfBits-1; i >=0; i--)
    {
      var x = Math.Pow(2, i);
      if (!(sum + x > num))
      {
        sum += (int)x;
        result = result + "1";
      }
      else
      {
        result = result + "0";
      }
    }
    return result;
  }
}