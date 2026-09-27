public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int lessCount = 0;
        int equalCount = 0;

        foreach (int number in nums)
        {
            if (number < pivot)
            {
                lessCount++;
            }
            else if (number == pivot)
            {
                equalCount++;
            }
        }

        int[] answer = new int[nums.Length];
        int lessIndex = 0;
        int equalIndex = lessCount;
        int greaterIndex = lessCount + equalCount;

        foreach (int number in nums)
        {
            if (number < pivot)
            {
                answer[lessIndex++] = number;
            }
            else if (number == pivot)
            {
                answer[equalIndex++] = number;
            }
            else
            {
                answer[greaterIndex++] = number;
            }
        }

        return answer;
    }
}