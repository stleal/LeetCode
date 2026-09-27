/********************
 * Name: Sam Leal 
 * Date: 04/30/2023 
 *******************/
 class Program
{
    public List<Integer> targetIndices(int[] nums, int target) 
    {
        ArrayList<Integer> answer; 
        answer = new ArrayList<Integer>(); 
        bubbleSort(nums); 
        for (int i = 0; i < nums.length; i++) 
        {
            if (nums[i] == target)
                answer.add(i); 
        }
        return answer; 
    }

    public void bubbleSort(int[] data) 
    {
        int swap; 
        swap = -1; 
        for (int i = 0; i < data.length; i++) 
        {
            for (int j = 0; j < data.length-1; j++) 
            {
                if (data[i] < data[j]) 
                {
                    swap = data[j]; 
                    data[j] = data[i]; 
                    data[i] = swap; 
                }
            }
        }
    }
    
}
