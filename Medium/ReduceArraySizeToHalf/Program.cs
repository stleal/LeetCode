/***************************************************************
 * Name: Sam Leal 
 * Date: 12/23/2023 
 * Filename: ReduceArraySizeToHalf.cs 
 * Description: You are given an integer array arr. You can 
 * choose a set of integers and remove all the occurrences of 
 * these integers in the array. 
 * 
 * Return a List<int[]> with each possible values of numbers that 
 * should be removed from the original array so that at least 
 * half of the integers of the array are removed. 
 * 
 * Example 1: 
 * 
 * Input: arr = [3,3,3,3,5,5,5,2,2,7] 
 * Output: {[3,7], [3,5], [3,2], [5,2]} 
 * Explanation: Choosing {3,7} will make the new array [5,5,5,2,2] 
 * which has size 5 (i.e equal to half of the size of the old array). 
 * Possible sets of size 2 are {3,5},{3,2},{5,2}. 
 * Choosing set {2,7} is not possible as it will make the new array 
 * [3,3,3,3,5,5,5] which has a size greater than half of the size of 
 * the old array.
***************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        List<int> sets;
        int[] arr, reducedArr; 

        // initialize local variables 
        arr = new int[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 };

        // get the first possible set to be removed from arr 
        sets = GetFirstPossibleSetToBeRemovedFromArray(arr);

        // reduce the array size to Half 
        reducedArr = ReduceArraySizeToHalf(arr, sets); 

        // stop 
        Console.ReadLine(); 

    }

    /***************************************************************
     * get the first possible set to be removed from arr
     * so that the array size will be less than or equal to half
     * when we remove all those elements in the set from arr 
     **************************************************************/
    public static List<int> GetFirstPossibleSetToBeRemovedFromArray(int[] arr)
    {

        // declare local variables 
        List<int> set;
        int size, sum, index;
        Dictionary<int, int> counts;

        // initialize local variables 
        sum = 0;
        size = arr.Length;
        set = new List<int>();
        counts = new Dictionary<int, int>();

        // count how many there are of each element 
        for (int i = 0; i < arr.Length; i++)
        {
            if (!counts.ContainsKey(arr[i]))
            {
                counts.Add(arr[i], 1);
            }
            else
            {
                counts[arr[i]]++;
            }
        }
        index = counts.Count - 1;

        // sort the Dictionary 
        counts = counts.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        // get the first possible solution 
        while (sum < (size / 2))
        {
            sum += counts.Values.ElementAt(index);
            set.Add(counts.Keys.ElementAt(index--));
        }

        // return set 
        return set;

    }

    public static int[] ReduceArraySizeToHalf(int[] arr, List<int> set)
    {

        // declare local variables 
        int size, count; 
        int[] reducedArr;

        // initialize local variables 
        size = 0;
        count = 0;

        // calculate the new size of the array 
        for (int i = 0; i < arr.Length; i++)
        {
            size += (!set.Contains(arr[i])) ? 1 : 0; 
        }
        reducedArr = new int[size];

        // insert only the elements that are not found in the sets List<int> 
        for (int i = 0; i < arr.Length; i++)
        {
            if (!set.Contains(arr[i]))
            {
                reducedArr[count++] = arr[i];
            }
        }

        return reducedArr; 

    }

    /***************************************************************
     * get all possibles set to be removed from arr
     * so that the array size will be less than or equal to half
     * when we remove all those elements in the set from arr 
     **************************************************************/
    public static List<List<int>> GetAllPossibleSetsToBeRemovedFromArray(int[] arr)
    {

        // declare local variables 
        List<List<int>> sets;
        int size, sum, index;
        List<int> set, elements;
        Dictionary<int, int> counts;

        // initialize local variables 
        sum = 0;
        size = arr.Length;
        sets = new List<List<int>>(); 
        counts = new Dictionary<int, int>();
        elements = new List<int>();

        // count how many there are of each element 
        for (int i = 0; i < arr.Length; i++)
        {
            if (!counts.ContainsKey(arr[i]))
            {
                counts.Add(arr[i], 1);
            }
            else
            {
                counts[arr[i]]++;
            }
        }
        index = counts.Count - 1;

        // sort the Dictionary 
        counts = counts.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        // get the first possible solution 
        while (sum < (size / 2))
        {
            sum += counts[index];
            elements.Add(counts.Keys.ElementAt(index--));
        }
        set = new List<int>(elements.Count); 
        for (int i = 0; i < elements.Count; i++)
        {
            set[i] = elements[i];
        }
        sets.Add(set);

        // return sets 
        return sets;

    }

}
