/********************
 * Name: Sam Leal 
 * Date: 04/29/2023 
 *******************/
 class Solution
{
    public int maxProduct(int[] nums)
    {
        int maximumProduct; 
        int indiceA; int indiceB; 
        
        maximumProduct = 0; 
        indiceA = 0; indiceB = 0; 

        for (int i = 0; i < nums.length; i++) 
        {
            for (int j = 0; j < nums.length; j++) 
            {
                if (nums[i] * nums[j] > maximumProduct && i != j)
                { 
                    maximumProduct = nums[i] * nums[j]; 
                    indiceA = i; 
                    indiceB = j; 
                }
            }
        }

        return (nums[indiceA]-1) * (nums[indiceB]-1); 

    }

}
