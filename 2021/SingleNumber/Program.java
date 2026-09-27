/*
 * Problem: Single Number
 * Description: Find the element that appears exactly once in an array while every other element appears twice.
 */

class Program
{
    public int singleNumber(int[] nums)
    {
        int num;
        ArrayList<Integer> count, numbers;
        boolean found;
        num = -1;
        count = new ArrayList<Integer>();
        numbers = new ArrayList<Integer>();
        found = false;
        // checks if the number has already been added to count
        for (int i = 0; i < nums.length; i++)
        {
            while (!found)
            {
                for (int j = 0; j < numbers.size(); j++)
                {
                    if (nums[i] == numbers.get(j))
                    {
                        count.set(j, count.get(j) + 1);
                        found = true;
                    }
                }
                if (!found)
                {
                    numbers.add(nums[i]);
                    count.add(0);
                }
            }
            found = false;
        }
        // gets the number that only appears once in the count ArrayList
        for (int i = 0; i < count.size(); i++)
        {
            if (count.get(i) == 1)
            {
                num = numbers.get(i);
            }
        }
        return num;
    }
}
