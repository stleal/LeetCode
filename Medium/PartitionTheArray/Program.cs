/*************************************************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 11/23/2023 
 * Filename: PartitionTheArray.cs 
 * Description: You are given a 0-indexed integer array nums and an integer pivot. 
 * 
 * Rearrange nums such that the following conditions are satisfied: 
 * 
 *  Every element less than pivot appears before every element greater than pivot. 
 *  Every element equal to pivot appears in between the elements less than and greater than pivot. 
 *  
 * The relative order of the elements less than pivot and the elements greater than pivot is maintained. More formally, consider every pi, 
 * pj where pi is the new position of the ith element and pj is the new position of the jth element. For elements less than pivot, if i < j and 
 * nums[i] < pivot and nums[j] < pivot, then pi < pj. 
 * 
 * Similarly for elements greater than pivot, if i < j and nums[i] > pivot and nums[j] > pivot, then pi < pj. 
 * Return nums after the rearrangement. 
 * 
 * Example 1: 
 * 
 * Input: nums = [9,12,5,10,14,3,10], pivot = 10 
 * Output: [9,5,3,10,10,12,14] 
 * 
 * Explanation: 
 *  
 *  The elements 9, 5, and 3 are less than the pivot so they are on the left side of the array. 
 *  The elements 12 and 14 are greater than the pivot so they are on the right side of the array. 
 *  The relative ordering of the elements less than and greater than pivot is also maintained. [9, 5, 3] and [12, 14] are the respective orderings.
 * 
*************************************************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int pivot; 
        int[] nums, pivotedArray;

        // initialize local variables 
        pivot = 10; 
        nums = new int[] { 9, 12, 5, 10, 14, 3, 10 };
        pivotedArray = PivotArray(nums, pivot);

        // Unit Test Case 
        pivot = 26; 
        nums = new int[] { 23, 26, 28, 29, 27, 25, 24, 26 };
        pivotedArray = PivotArray(nums, pivot);

        // Unit Test Case 
        pivot = 8;
        nums = new int[] { 8, 10, 11, 5, 13, 10, 6, 9, 7, 8 };
        pivotedArray = PivotArray(nums, pivot);

        // stop 
        Console.ReadLine(); 

    }

    // partitions the Array 
    public static int[] PivotArray(int[] nums, int pivot)
    {

        // declare local variables 
        List<int> l;
        int pivotCount;
        int[] pivotedArray;
        int lessThanCursor, pivotCursor;

        // initialize local variables 
        pivotCount = 0;
        l = new List<int>();
        lessThanCursor = pivotCursor = 0;
        pivotedArray = new int[nums.Length];

        // partition the Array 
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > pivot)
            {
                l.Add(nums[i]);
            } 
            else if (nums[i] == pivot) 
            {
                l.Insert(pivotCursor++, nums[i]);
                pivotCount++;
            }
            else if (nums[i] < pivot)
            {
                l.Insert(lessThanCursor++, nums[i]);
                pivotCursor = lessThanCursor + pivotCount;
            }
        }

        // copy the partitions into the pivoted Array 
        l.CopyTo(pivotedArray);

        // return the pivoted Array 
        return pivotedArray;

    }

} 
