public class Program {
    public int[] NumberGame(int[] nums) {
        int cursor = 0;
        List<int> numsList = new List<int>();
        foreach (var num in nums)
        {
            numsList.Add(num);
        }
        int[] arr = new int[nums.Length];
        while (numsList.Count() > 0)
        {
            numsList.Sort();
            int num1 = numsList[0];
            numsList.Remove(num1);
            int num2 = numsList[0];
            numsList.Remove(num2);
            arr[cursor++] = num2;            
            arr[cursor++] = num1;
        }
        return arr;
    }
}