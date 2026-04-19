public class CreateTargetArraySolution
{
  public int[] CreateTargetArray(int[] nums, int[] index)
  {
    int[] target = new int[nums.Length];
    // initialize target array to -1
    for (int i = 0; i < target.Length; i++)
    {
        target[i] = -1;
    }
    // insert into array at cursor
    for (int i = 0; i < index.Length; i++)
    {
        // the index where nums[i] should go into target
        var cursor = index[i];
        // shift all elements to the right by 1 if an element already exists at target[cursor]
        if (target[cursor] != -1)
        {
            var pos = 0;
            var startIndex = cursor;
            int[] temp = new int[target.Length-cursor-1];
            for (int j = pos; j < target.Length-cursor-1; j++)
            {
                temp[pos++] = target[startIndex++];
            }
            target[cursor] = nums[i];
            startIndex = 0;
            // copy temp back into target
            for (int j = cursor+1; j < target.Length; j++)
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