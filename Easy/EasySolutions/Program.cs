public class Program
{
  public static void Main(String[] args)
  {
    CreateTargetArray();
  }

  public static int[] CreateTargetArray()
  {
    CreateTargetArraySolution solution = new CreateTargetArraySolution();
    int[] nums = new int[] { 0, 1, 2, 3, 4 };
    int[] index = new int[] { 0, 1, 2, 2, 1 };
    int[] result = solution.CreateTargetArray(nums, index);
    Console.WriteLine("Target array: " + string.Join(", ", result));
    return result;
  }

  public static string MapWordWeights()
  {
    string[] words = new string[] { "abcd","def","xyz" };
    int[] weights = new int[] { 5,3,12,14,1,2,3,2,10,6,6,9,7,8,7,10,8,9,6,9,9,8,3,7,7,2 };
    MapWordWeightsSolution solution = new MapWordWeightsSolution();
    string result = solution.MapWordWeights(words, weights);
    Console.WriteLine("Mapped word weights: " + result);
    words = new string[] { "light", "it", "up" };
    weights = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
    Console.WriteLine("Mapped word weights: " + solution.MapWordWeights(words, weights));
    return result;
  }

  public static int MinMovesToSeat()
  {
    MinMovesToSeatSolution solution = new MinMovesToSeatSolution();
    int[] seats = new int[] { 3, 1, 5 };
    int[] students = new int[] { 2, 7, 4 };
    int result = solution.MinMovesToSeat(seats, students);
    Console.WriteLine("Minimum number of moves to seat students: " + result);
    return result;
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