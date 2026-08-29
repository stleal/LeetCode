public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[] { 0, 1, 2, 3, 4 };
        int[] index = new int[] { 0, 1, 2, 2, 1 };
        var result = CreateTargetArray(nums, index);
        Console.WriteLine("Target array: " + string.Join(", ", result));
    }

    public static int[] CreateTargetArray(int[] nums, int[] index)
    {
        int[] target = new int[nums.Length];
        for (int i = 0; i < target.Length; i++)
        {
            target[i] = -1;
        }

        for (int i = 0; i < index.Length; i++)
        {
            var cursor = index[i];
            if (target[cursor] != -1)
            {
                var pos = 0;
                var startIndex = cursor;
                int[] temp = new int[target.Length - cursor - 1];
                for (int j = pos; j < target.Length - cursor - 1; j++)
                {
                    temp[pos++] = target[startIndex++];
                }
                target[cursor] = nums[i];
                startIndex = 0;
                for (int j = cursor + 1; j < target.Length; j++)
                {
                    target[j] = temp[startIndex++];
                }
            }
            else
            {
                target[cursor] = nums[i];
            }
        }
        return target;
    }
}