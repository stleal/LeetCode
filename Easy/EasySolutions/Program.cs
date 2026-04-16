public class Program
{
  public static void Main(String[] args)
  {
    ReverseDegree();
  }

  public static int ReverseDegree()
  {
    string s = "abc";
    ReverseDegreeOfStringSolution solution = new ReverseDegreeOfStringSolution();
    int result = solution.ReverseDegree(s);
    Console.WriteLine("Reverse degree of string " + s + " is: " + result);
    return result;
  }

  public static string ClearDigits()
  {
    Console.WriteLine("Hello World!");
    // string s = "1cb34a5abc";
    string s = "li5i56";
    ClearDigitsSolution clearDigitsSolution = new ClearDigitsSolution();
    string result = clearDigitsSolution.ClearDigits(s);
    Console.WriteLine("String after clearing digits: " + result);
    return result;
  }

  public static int MinOperations()
  {
    MinOperationsSolution solution = new MinOperationsSolution();
    int remainder = solution.MinOperations(new int[] { 5, 4, 3, 2, 1}, 6);
    Console.WriteLine("15 % 6 = " + remainder);
    Console.WriteLine("Mininmum number of operations to make sum of array divisible by 6 is: " + remainder);
    return remainder;
  }

  public static int MaxFreqSum(string s)
  {
    MaxFreqSumSolution solution = new MaxFreqSumSolution();
    return solution.MaxFreqSum(s);
  }

  public static void FindWordsContaining()
  {
  }

  public static void ScoreOfString()
  {
  }
}