public class Program {
  public static void Main(string[] args)
  {
    var answer = LeftRightDifference(new int[] { 10, 4, 8, 3 });
    Console.WriteLine(string.Join(", ", answer));
    answer = LeftRightDifference(new int[] { 1 });
    Console.WriteLine(string.Join(", ", answer));
  }

  public static int[] LeftRightDifference(int[] nums) {
      List<int> answer = new List<int>();
      List<int> leftSumList = new List<int>();
      List<int> rightSumList = new List<int>();
      for (int i = 0; i < nums.Length; i++)
      {
          int leftSum = 0;
          if (i > 0)
          {
              for (int j = i-1; j >= 0; j--)
              {
                  leftSum += nums[j];
              }
          }
          leftSumList.Add(leftSum);
          int rightSum = 0;
          if (i < nums.Length)
          {
              for (int j = i+1; j < nums.Length; j++)
              {
                  rightSum += nums[j];
              }
          }
          rightSumList.Add(rightSum);
          int ans = Math.Abs(leftSumList[i] - rightSumList[i]);
          answer.Add(ans);
      }
      return answer.ToArray();
  }

  public static int[] LeftRightDifferenceOptimized(int[] nums) {
      int[] answer = new int[nums.Length];
      int totalSum = nums.Sum();
      int leftSum = 0;

      for (int i = 0; i < nums.Length; i++)
      {
          int rightSum = totalSum - leftSum - nums[i];
          answer[i] = Math.Abs(leftSum - rightSum);
          leftSum += nums[i];
      }

      return answer;
  }
}