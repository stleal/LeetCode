public class Program
{
  public static void Main(String[] args)
  {
    MinOperations();
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