public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var intList = new List<int>();
        foreach (var num in nums)
        {
        if (intList.Contains(num))
            return true;
        intList.Add(num);
        }
        return false;
    }
}