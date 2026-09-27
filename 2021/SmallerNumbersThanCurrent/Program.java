class Program
{
    public int[] smallerNumbersThanCurrent(int[] nums)
    {
        // declares our local variables
        int num, index;
        int[] smallerNums;
        ArrayList<Integer> count;
        // initializes our local variables
        num = -1;
        index = -1;
        smallerNums = new int[nums.length];
        count = new ArrayList<Integer>();
        // initializes count
        for (int i = 0; i < nums.length; i++)
        {
            count.add(0);
        }
        // counts the occurence of smaller numbers
        for (int i = 0; i < nums.length; i++)
        {
            num = nums[i];
            index = i;
            for (int j = 0; j < nums.length; j++)
            {
                if (nums[j] < num && index != j)
                {
                    count.set(i, count.get(i) + 1);
                }
            }
        }
        // copies the ArrayList<Integer>, count, into smallerNums int[]
        for (int i = 0; i < count.size(); i++)
        {
            smallerNums[i] = count.get(i);
        }
        return smallerNums;
    }
}
