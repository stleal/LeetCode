public class Program {
    public int[] LeftRightDifference(int[] nums) {
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