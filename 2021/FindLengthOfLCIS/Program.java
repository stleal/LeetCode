class Program
{
    public int findLengthOfLCIS(int[] nums)
    {
        int count;
        int lengthOfLCIS;
        lengthOfLCIS = -1;
        count = 1;
        for (int i = 0; i < nums.length - 1; i++)
        {
            if (nums[i] < nums[i+1])
            {
                count++;
            }
            else
            {
                if (count > lengthOfLCIS)
                {
                    lengthOfLCIS = count;
                }
                count = 1;
            }
        }
        if (count > lengthOfLCIS)
        {
            lengthOfLCIS = count;
        }
        return lengthOfLCIS;
    }
}
