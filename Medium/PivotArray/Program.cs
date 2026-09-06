public class Program {

    public static void Main(string[] args)
    {
        int[] nums = { 9, 12, 5, 10, 14, 3, 10 };
        int pivot = 10;
        int[] result = PivotArray(nums, pivot);
        Console.WriteLine(string.Join(", ", result));
    }

    public static int[] PivotArray(int[] nums, int pivot) {
        int index = 0;
        int[] answer = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                answer[index++] = nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == pivot)
            {
                answer[index++] = nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > pivot)
            {
                answer[index++] = nums[i];
            }
        }
        return answer;
    }
}