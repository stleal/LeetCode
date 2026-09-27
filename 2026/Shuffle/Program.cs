public class Program {
    public int[] Shuffle(int[] nums, int n) {
        int index = 0;
        int[] numsShuffled = new int[nums.Length];
        for (int i = 0; i < nums.Length; i+=2)
        {
            numsShuffled[i] = nums[index];
            numsShuffled[i+1] = nums[index+n];
            index++;
        }
        return numsShuffled;
    }
}