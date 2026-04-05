/*******************************************************************
 * Name: Sam Leal 
 * Date: 12/25/2023 
 * Filename: NumberOfSubArrays.cs  
 * Description: Given an array of integers arr and two integers 
 * k and threshold, return the number of sub-arrays of size k and 
 * average greater than or equal to threshold.
*******************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] arr;
        int k, threshold;
        List<double> averages; 
        List<List<int>> subArrays;

        // initialize local variables 
        k = 4;
        threshold = 4;

        // length of array factorial up to size of k 
        // yeild's 1,680 possible subsets when k == 4, 40,320 subsets when k == 8 
        // when k == 4 => 8 * 6 * 7 * 5 possible subsets => 1,680 
        // when k == 8 => 8 * 6 * 7 * 5 * 4 * 3 * 2 * 1 possible subsets => 40,320 
        arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; 

        // additional sample arrays 
        //arr = new int[] { 2, 2, 2, 2, 5, 5, 5, 8 };
        //arr = new int[] { 6, 6, 5, 4, 9, 11, 10, 12, 16, 18, 24, 26 };

        // get the sub-arrays 
        subArrays = GetSubArrays(arr, k, threshold);

        // print the sub-arrays 
        PrintSubArrays(subArrays);

        // get the average of each sub-array, and 
        // compare it to the threshold value 
        averages = GetAverageOfEachSubArray(subArrays); 

        // stop 
        Console.ReadLine(); 

    } 

    // gets the sub-arrays given an int[] arr, int k, and int treshold 
    public static List<List<int>> GetSubArrays(int[] arr, int k, int threshold)
    {

        // declare local variables 
        int cursor, counter;
        List<int> subArray, indices;
        Dictionary<List<int>, List<int>> subArrays; 

        // initialize local variables 
        cursor = 0;
        counter = 0;
        indices = new List<int>(); 
        subArray = new List<int>(); 
        subArrays = new Dictionary<List<int>, List<int>>(); 

        // get all possible permutations of sub-arrays 
        // for example, given the arr => { 1, 2, 3, 4, 5, 6, 7, 8 } 
        for (int i = 0; i < arr.Length; i++)
        {
            for (int l = 0; l < arr.Length - 1; l++)
            {
                indices.Add(i);
                subArray.Add(arr[i]);
                for (int j = l; subArray.Count() < 2; j++)
                {
                    if (j != i && j != cursor)
                    {
                        indices.Add(j); 
                        subArray.Add(arr[j]);
                        subArrays.Add(subArray, indices); 
                        if (subArray.Count() == 2)
                        {
                            cursor = j;
                        }
                        counter++; 
                    }
                }
                indices = new List<int>();
                subArray = new List<int>();
            }
            cursor = i+1;
        }

        // recursively call the GetSubArrays method 
        subArrays = GetSubArrays(subArrays, arr, k - 2); 

        // return all possible permutations of sub-arrays 
        return subArrays.Keys.ToList(); 

    } 

    // get all subsets from arr recursively 
    public static Dictionary<List<int>, List<int>> GetSubArrays(Dictionary<List<int>, List<int>> subArrays, int[] arr, int k)
    {
        int x;
        List<int> setKeys, setValues; 
        Dictionary<List<int>, List<int>> subsets;

        x = k;
        setKeys = new List<int>();
        setValues = new List<int>(); 
        subsets = new Dictionary<List<int>, List<int>>();
        if (x >= 1)
        {
            foreach (KeyValuePair<List<int>, List<int>> subset in subArrays)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!subset.Value.ToList().Contains(i))
                    {
                        for (int j = 0; j < subset.Key.Count(); j++)
                        {
                            setKeys.Add(subset.Key[j]);
                            setValues.Add(subset.Value[j]);
                        }
                        setKeys.Add(arr[i]);
                        setValues.Add(i);
                        subsets.Add(setKeys, setValues);
                        setKeys = new List<int>();
                        setValues = new List<int>(); 
                    }
                }
            }
            x--;
            if (x == 0)
            {
                return subsets;
            }
        }
        subsets = GetSubArrays(subsets, arr, x);
        return subsets;
    }

    // prints the sub-arrays 
    public static void PrintSubArrays(List<List<int>> subArrays)
    {
        try
        {
            // write to results.txt file 

        } 
        catch (IOException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    // get the average of each sub-array 
    public static List<double> GetAverageOfEachSubArray(List<List<int>> subArrays)
    {

        // declare local variables 
        int sum;
        double average; 
        List<double> averages;

        // initialize local variables 
        sum = 0; 
        average = 0; 
        averages = new List<double>(); 

        // calculate the average of the sum of all the elements 
        for (int i = 0; i < subArrays.Count; i++)
        {
            for (int j = 0; j < subArrays.ElementAt(i).Count; j++)
            {
                sum += subArrays.ElementAt(i).ElementAt(j); 
            }
            average = (sum / subArrays.ElementAt(i).Count);
            averages.Add(average);
            sum = 0; 
        }

        // return the averages 
        return averages; 

    }

}
