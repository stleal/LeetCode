public class Program {
    public int[] ResultArray(int[] nums) {
        List<int> arr1 = new List<int> { nums[0] };
        List<int> arr2 = new List<int> { nums[1] };
        for (int i = 2; i < nums.Length; i++)
        {
            if (arr1[arr1.Count()-1] > arr2[arr2.Count()-1])
            {
                arr1.Add(nums[i]);
            }
            else
            {
                arr2.Add(nums[i]);
            }
        }
        List<int> result = new List<int>();
        result.AddRange(arr1);
        result.AddRange(arr2);
        return result.ToArray();
    }
}