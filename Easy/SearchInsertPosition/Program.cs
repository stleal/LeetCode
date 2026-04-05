/********************
 * Name: Sam Leal
 * Date:05/15/2025
 *******************/
class Program
{
  public int searchInsert(int[] nums, int target)
  {
    // declare variables
    int start;
    int end;

    // initialize variables
    start = 0;
    end = nums.Length - 1;

    // searches for target
    while (start <= end)
    {
      // binary search
      int middle = (start + end) / 2;
      if (nums[middle] == target)
        return middle;
      if (nums[middle] < target)
        start = middle + 1;
      if (nums[middle] > target)
        end = middle - 1;
    }
    return start;
  }
}