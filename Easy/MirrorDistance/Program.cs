public class Program
{
  public static void Main(string[] args)
  {
    var result = MirrorDistance(25);
    Console.WriteLine("The mirror distance is: " + result);
  }
  public static int MirrorDistance(int n)
  {
    return Math.Abs(n - Reverse(n));
  }
  public static int Reverse(int n)
  {
    string reversed = "";
    while (n > 0)
    {
      int digit = n % 10;
      reversed += digit.ToString();
      n /= 10;
    }
    return Convert.ToInt32(reversed);
  }
}