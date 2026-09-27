public class Program {
    public int SplitArray(int[] nums, int k) {

        if (nums.Length < 1)
            return 0;

        if (nums.Length < 2)
            return nums[0];

        if (nums.Length == 2 && k == 1)
            return nums[0] + nums[1];

        int lowerBound = 0;
        int upperBound = 0;

        for (int index = 0; index < nums.Length; index++)
        {
            lowerBound = Math.Max(lowerBound, nums[index]);
            upperBound += nums[index];
        }

        return BinarySearch(nums, k, lowerBound, upperBound);
    }

    public int BinarySearch(int[] nums, int k, int left, int right)
    {
        while (left < right)
        {
            int middle = left + (right - left) / 2;

            if (CanSplit(nums, k, middle))
            {
                right = middle;
                continue;
            }

            left = middle + 1;
        }

        return left;
    }

    private bool CanSplit(int[] nums, int k, int maxAllowedSum)
    {
        int subarrayCount = 1;
        int runningSum = 0;

        for (int index = 0; index < nums.Length; index++)
        {
            if (runningSum + nums[index] <= maxAllowedSum)
            {
                runningSum += nums[index];
                continue;
            }

            subarrayCount++;
            runningSum = nums[index];

            if (subarrayCount > k)
                return false;
        }

        return true;
    }

}