/***************************************************************************
 * Name: Sam Leal 
 * Date: 12/28/2023 
 * Filename: PancakeSorting.cs  
 * Description: Given an array of integers arr, sort the array by 
 * performing a series of pancake flips.
 * 
 * In one pancake flip we do the following steps: 
 *   
 *   1) Choose an integer k where 1 <= k <= arr.length. 
 *   2) Reverse the sub-array arr[0...k-1] (0-indexed). 
 *   
 * For example, if arr = [3,2,1,4] and we performed a pancake flip 
 * choosing k = 3, we reverse the sub-array [3,2,1], so arr = [1,2,3,4] 
 * after the pancake flip at k = 3. 
 * 
 * Return an array of the k-values corresponding to a sequence of pancake 
 * flips that sort arr. Any valid answer that sorts the array within 
 * 10 * arr.length flips will be judged as correct. 
***************************************************************************/
using Dapper;
using System.Data;
using System.Data.SqlClient;

public class Program
{

    // global variables 
    // connection string 
    private static string _connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PancakeSortingApp;" +
        "Trusted_Connection=TRUE;Encrypt=FALSE;server=(LocalDb)\\MSSQLLocalDB;database=PancakeSortingApp"; 

    // main 
    public static void Main(string[] args)
    {

        /**********************************************************************************
         * Unit Test Cases should all: 
         * 
         *   1) Randomly generate an unsorted array of size between 2 - maxSize or 
         *      provide a hard-coded unsorted array of integers (see Unit Test Case 02). 
         *   2) Get the sequence given the provided unsorted array of integers.
         *   3) Sort the array in ascending order using the PancakeFlip method given the 
         *   provided unsorted array, and sequence as derived in the previous step (2). 
         *   4) Verify that the array is sorted in the correct order (ascending). 
         *   5) Saves the unsorted array, sorted array, and the seqeuence to the database. 
         *   
         *   OR: (you may also) 
         *   
         *   1) Randomly generate an unsorted array of size between 2 - maxSize or 
         *      provide a hard-coded unsorted array of integers (see Unit Test Case 02). 
         *   2) Call the overload PancakeFlip method directly given an unsorted array, which will 
         *      derive the sequence, and then sort the array in ascending order using the PancakeFlip 
         *      using an all-in-one method, and returns the sequence 
         *   3) Verify that the array is sorted in the correct order (ascending). 
         *   4) Saves the unsorted array, sorted array, and the seqeuence to the database. 
         *   
         **********************************************************************************/

        // Unit Test Case 01 
        UnitTestCase01();

        // Unit Test Case 02 
        UnitTestCase02();

        // Unit Test Case 03
        UnitTestCase03();

        // Unit Test Case 04 
        UnitTestCase04();

        // stop   
        Console.ReadLine(); 

    } 

    // performs the pancake Flip on an unsorted Array
    // returns the sorted array 
    public static List<int> PancakeFlip(int[] unsortedArray, List<int> sequence)
    {

        // declare local variables 
        List<int> flippedArray, sortedArray;

        // initialize local variables 
        flippedArray = new List<int>();
        sortedArray = unsortedArray.ToList();

        // apply a permutation 
        for (int i = 0; i < sequence.Count; i++)
        {

            // for logging purposes 
            Console.WriteLine("Permuting...");
            Console.Write((i + 1) + "/" + sequence.Count + ": ");

            // flip 
            for (int j = sequence.ElementAt(i); j >= 0; j--)
            {
                flippedArray.Add(sortedArray[(j)]);
                Console.Write(sortedArray[(j)] + ", ");
            }

            // add the remaining non-flipped elements/partition back into the new flipped partition/array 
            for (int j = flippedArray.Count; j < sortedArray.Count(); j++)
            {
                flippedArray.Add(sortedArray[j]);
                Console.Write(sortedArray[(j)] + ", ");
            }
            Console.WriteLine();

            // save flip into permuatedArray 
            sortedArray = flippedArray;
            flippedArray = new List<int>();

        }

        // returns the permuted array  
        return sortedArray;

    }

    // overload method on the PancakeFlip method 
    // performs the pancake flip on an unsorted Array
    // saves to database, if sorted correctly 
    // returns the sequence
    public static List<int> PancakeFlip(int[] unsortedArray)
    {

        // declare local variables 
        bool sorted;
        List<int> sequence, sortedArray;

        // initialize local variables 
        sortedArray = new List<int>();
        sequence = GetSequence(unsortedArray);

        // returns the permuted array 
        sortedArray = PancakeFlip(unsortedArray, sequence);

        // verify that the array is sorted in ascending order 
        sorted = IsSortedAscending(sortedArray.ToList());
        if (sorted)
        {

            // prints the sequence 
            PrintArray(sequence);

            // prints the sequence 
            PrintArray(sortedArray);

            // save to file 
            SaveToDatabase(unsortedArray, sequence, sortedArray.ToArray());

        } 
        else
        {
            throw new Exception("Not sorted correctly, wrong sequence!");
        }

        // return the sequence  
        return sequence;

    }

    /***************************************************************************************************
     * GetSequence(List<int> unsortedArray): returns a List<int> that when used in the Pancake Sorting 
     * method with the provided unsortedArray, it will sort the array in ascending order. 
     * 
     * the sequence is derived using the following formula: 
     * 
     * while the array is not sorted, repeated the following: 
     * 
     * 1) check if the unsorted array is in at least partially decreasing order, i.e.: (5, 4, 3, 6, 7, 1), 
     *    if so, sort the array in ascending order using a pancake flip operation from 0 to the index of the 
     *    last decreasing number (or, the first "increasing" number but not including that number), inclusive 
     * 2) now that the array is sorted in ascending order (at least partially), i.e.: 3, 4, 5, 6, 7, 1, get the 
     *    index of the last increasing number, in this case that would be: 4, since index[4] = 7, and index[5] = 1
     * 3) verify that the array is not completely sorted in ascending order, because it could be now after performing 
     *    the swap in step 1, for example from {5, 4, 3, 6, 7, 8}, to {3, 4, 5, 6, 7, 8}, and so now we're done. 
     * 4) if the array is not completely sorted after verifying in step 3, then apply one of the following permutations: 
     * 
     *    4a) if (Math.Abs(permutedArray[index + 1] - permutedArray[index]) == 1)  
     *      
     *      4aa) add +1 to the index from the previous in step 2, it was the index of the last increasing number, 
     *      4ab) perform a pancake flip on a partition of this array from 0 to index 
     *      4ac) get the index of the last increasing number 
     *      4ad) perform another pancake flip operation from index of 0 to the index retrieved in 4ac 
     *      4ae) go to step 5. 
     *    
     *    4b) if (permutedArray[index + 1] - permutedArray[0] == 1)   
     *    
     *      4ba) using the index from step 2, permute the array from index of 0 to index inclusive 
     *      4bb) add +1 to index, and permute the array again from 0 to index  
     *      4bc) swap the first two numbers by performing a permutation from 0 to index of 1
     *      4bd) go to step 5. 
     *    
     *    4c) if (permutedArray[index + 1] - permutedArray[0] > 1) 
     *    
     *      4ca) using the index from step 2, add +1 to the index value, and then perform a pancake flip 
     *           on the unsorted array from index of 0 to index. 
     *      4cb) search for the index where the difference between permutedArray[i] and permutedArray[0] is 
     *           less than 1, by looping through the permuted array from i = 1 to the end of the permuted array, 
     *           when found - subtract one from it and save it into the index variable. 
     *      4cc) perform a permutation on the permutedArray from index of 0 to the new index value found in 
     *           the previous step, 4cb. 
     *      4cd) next, if the index value from 4cd does not equal 1, then subtract one from the index value, 
     *           and perform one final pancake flip on the permuted array from index of 0 to the new index value. 
     *      4ce) go to step 5. 
     *    
     *    4d) if (permutedArray[index + 1] - permutedArray[0] < 1) 
     *    
     *      4da) perform a pancake flip from index of 0 to index from step 2 
     *      4db) go to step 5. 
     *    
     * 5) repeat steps 1-4, until the array is sorted. 
     ***************************************************************************************************/
    public static List<int> GetSequence(int[] unsortedArray)
    {

        // declare local variables 
        int index;
        bool sorted, isDecreasingOrder;
        List<int> permutedArray, seqeunce;

        // initialize local variables 
        sorted = false;
        seqeunce = new List<int>();
        permutedArray = unsortedArray.ToList();

        // sort the array and return the correct permutation/sequence
        // that will sort the array in ascending order using the pancake flip method 
        while (!sorted)
        {

            // check if the array is at least partially in decreasing order 
            index = GetIndexOfLastDecreasingNumber(permutedArray);
            isDecreasingOrder = (index > 0) ? true : false; 
            if (isDecreasingOrder)
            {
                permutedArray = FlipPartition(permutedArray, index);
                seqeunce.Add(index);
            }

            // search for the index of the first non-increasing number / last increasing number 
            index = GetIndexOfLastIncreasingNumber(permutedArray);
            sorted = (index == unsortedArray.Length - 1) ? true : false;

            // sort a partition/array 
            if (!sorted)
            {

                // apply a permutation on the array 
                if (Math.Abs(permutedArray[index + 1] - permutedArray[index]) == 1)
                {

                    // perform a permute on this partition 
                    index += 1;
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                    // swap up to the last increasing number / the first decreasing number but not including that number 
                    index = GetIndexOfLastIncreasingNumber(permutedArray); 
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                }
                else if (permutedArray[index + 1] - permutedArray[0] == 1)
                {

                    // perform a permute on this partition 
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                    // perform a permute on this partition 
                    index += 1;
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                    // swap the first two numbers 
                    index = 1;
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                }
                else if (permutedArray[index + 1] - permutedArray[0] > 1)
                {

                    // perform a permute on this partition 
                    index += 1;
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                    // search for the index, where permutedArray[i] - permuatedArray[0] < 1
                    for (int i = 1; i < permutedArray.Count; i++)
                    {
                        if (permutedArray[i] - permutedArray[0] < 1)
                        {
                            index = i - 1; 
                            break; 
                        }
                    }

                    // perform a permute on this partition 
                    permutedArray = FlipPartition(permutedArray, index);
                    seqeunce.Add(index);

                    // perform a permute on this partition 
                    if (index != 1)
                    {
                        index -= 1;
                        permutedArray = FlipPartition(permutedArray, index);
                        seqeunce.Add(index);
                    }

                } 
                else if (permutedArray[index + 1] - permutedArray[0] < 1)
                {

                    // perform a permute on this partition 
                    permutedArray = FlipPartition(permutedArray, index); 
                    seqeunce.Add(index);

                }

            } 

        }

        // return the correct sequence 
        return seqeunce; 

    }

    // generate a random sized array with test data (unsorted) 
    public static int[] GenerateUnsortedArray(int maxSize)
    {

        // declare local variables 
        Random r;
        int size, n, count;
        int[] unsortedArray;

        // Unit Test Case 01 
        // initialize local variables 
        count = 0;
        r = new Random();
        size = r.Next(2, maxSize + 1);
        unsortedArray = new int[size];
        Console.Write("The Unsorted Array: ");
        while (count < unsortedArray.Length)
        {
            n = r.Next(1, size + 1);
            if (!unsortedArray.Contains(n))
            {
                unsortedArray[count] = n;
                Console.Write(n + ", ");
                count++;
            }
        }

        // returns the randomly generated array (unsorted) 
        return unsortedArray;

    }

    // returns the index of the last increasing number 
    // for example, given the arr: { 8, 7, 5, 6, 4, 3, 2, 1 } 
    // returns: 0 (because 7 < 8) 
    // for example, given the arr: { 1, 2, 3, 4, 6, 5, 7, 8 } 
    // returns: 4 (because 5 < 6) 
    public static int GetIndexOfLastIncreasingNumber(List<int> permutedArray)
    {
        int index;
        index = permutedArray.Count - 1; 
        for (int i = 0; i < permutedArray.Count - 1; i++)
        {
            if (permutedArray[i] > permutedArray[i + 1])
            {
                index = i;
                break; 
            } 
        }
        return index; 
    }

    // returns the index of the last decreasing number 
    // for example, given the arr: { 8, 7, 5, 6, 4, 3, 2, 1 } 
    // returns: 2 (because 6 > 5) 
    // for example, given the arr: { 1, 2, 3, 4, 6, 5, 7, 8 } 
    // returns: 0 (because 2 > 1) 
    public static int GetIndexOfLastDecreasingNumber(List<int> permutedArray)
    {
        int index; 
        index = permutedArray.Count - 1; 
        for (int i = 0; i < permutedArray.Count - 1; i++)
        {
            if (permutedArray[i] < permutedArray[i + 1])
            {
                index = i;
                break; 
            }
        }
        return index; 
    }

    // returns whether the array is sorted in ascending order or not 
    public static bool IsSortedAscending(List<int> permutedArray)
    {
        bool sorted;
        sorted = true;
        for (int i = 0; i < permutedArray.Count - 1; i++)
        {
            if (permutedArray[i] > permutedArray[i + 1])
            {
                sorted = false;
                break; 
            }
        }
        return sorted;
    }  

    // flips a partition from an array from index of 0 up until endIndex 
    public static List<int> FlipPartition(List<int> partition, int endIndex)
    {

        // declare local variables 
        List<int> flippedPartition;

        // initialize local variables 
        flippedPartition = new List<int>();

        // flips the partition from index 0 to endIndex 
        Console.WriteLine("Permuting...");
        for (int j = endIndex; j >= 0; j--)
        {
            flippedPartition.Add(partition[(j)]);
            Console.Write(partition[(j)] + ", ");
        }

        // adds the remaining elements to the flipped partition at the end 
        for (int j = flippedPartition.Count; j < partition.Count(); j++)
        {
            flippedPartition.Add(partition[j]);
            Console.Write(partition[(j)] + ", ");
        }
        Console.WriteLine();

        // return the flipped Partition   
        return flippedPartition;

    }

    // prints an array of integers 
    public static void PrintArray(List<int> arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write(arr[i] + ", ");
        }
    }

    // save to database 
    public static void SaveToDatabase(int[] unsortedArray, List<int> sequence, int[] sortedArray) 
    {

        // declare local variables 
        string unsArr, sortedArr, sequenceStr;
        int lengthOfUnsortedArray, isValidSequence;
        int numberOfStepsInSequence, maximumNumberOfStepsAllowed;

        // initialize local variables 
        isValidSequence = 1;
        unsArr = string.Empty;
        sortedArr = string.Empty;
        sequenceStr = string.Empty;
        numberOfStepsInSequence = sequence.Count;
        lengthOfUnsortedArray = unsortedArray.Length;
        maximumNumberOfStepsAllowed = lengthOfUnsortedArray * 10;

        // saves the data into var strings to be saved into the database 
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            unsArr += unsortedArray[i] + ", ";
            sortedArr += sortedArray[i] + ", ";
        }

        // trim the ending ", " 
        unsArr = unsArr.Substring(0, unsArr.Length - 2);
        sortedArr = sortedArr.Substring(0, sortedArr.Length - 2);

        // saves the sequence into var sequence 
        for (int i = 0; i < sequence.Count(); i++)
        {
            sequenceStr += sequence[i] + ", ";
        }

        // trim the ending ", " 
        sequenceStr = sequenceStr.Substring(0, sequenceStr.Length - 2);

        try
        {
            // save the data to the db 
            using (var connection = new SqlConnection(_connectionString))
            {
                PancakeFlips pancakeFlip = new PancakeFlips()
                {
                    unsArr = unsArr,
                    sortedArr = sortedArr,
                    sequenceStr = sequenceStr,
                    numberOfStepsInSequence = numberOfStepsInSequence,
                    maximumNumberOfStepsAllowed = maximumNumberOfStepsAllowed,
                    lengthOfUnsortedArray = lengthOfUnsortedArray,
                    isValidSequence = isValidSequence
                };
                connection.Execute("InsertPancakeFlip", pancakeFlip, commandType: CommandType.StoredProcedure); 
            }
        } 
        catch (Exception ex)
        {
            throw new Exception("Error saving to database", ex.InnerException); 
        }

    }

    // Unit Test Case 01 
    public static void UnitTestCase01()
    {

        // declare local variables 
        bool sorted;
        List<int> sequence;
        int[] unsortedArray, sortedArray;

        // randomly generates an unsorted array of integers with a size between 2 - maxSize 
        // gets the sequence that will sort the array in ascending order using the PancakeFlip method 
        // performs the Pancake Flip on the unsorted Array 
        // verifies that the array is sorted in ascending order 
        unsortedArray = GenerateUnsortedArray(100);
        sequence = GetSequence(unsortedArray);
        sortedArray = PancakeFlip(unsortedArray, sequence).ToArray();
        sorted = IsSortedAscending(sortedArray.ToList());
        if (sorted)
        {
            SaveToDatabase(unsortedArray, sequence, sortedArray);
        } 
        else
        {
            throw new Exception("Not sorted correctly, wrong sequence!"); 
        }

    }

    // Unit Test Case 02
    public static void UnitTestCase02()
    {

        // declare local variables 
        bool sorted;
        List<int> sequence;
        int[] unsortedArray, sortedArray;

        // gets the sequence that will sort the array in ascending order using the PancakeFlip method 
        // performs the Pancake Flip on the unsorted Array 
        // verifies that the array is sorted in ascending order 
        // saves the unsorted array, sequence, and unsorted array to a file if the array has been sorted correctly 
        unsortedArray = new int[] { 1, 2, 3, 4, 6, 5 };
        sequence = GetSequence(unsortedArray);
        sortedArray = PancakeFlip(unsortedArray, sequence).ToArray();
        sorted = IsSortedAscending(sortedArray.ToList());
        if (sorted)
        {
            SaveToDatabase(unsortedArray, sequence, sortedArray);
        }
        else
        {
            throw new Exception("Not sorted correctly, wrong sequence!");
        }

    }

    // Unit Test Case 03
    // randomly generates an unsorted array of integers with a size between 2 - maxSize 
    // calls the overload PancakeFlip method, which gets the sequence, and then 
    // performs the PancakeFlip on the unsorted Array, to sort the array, and then 
    // verifies that the array is sorted in ascending order, and saves to the file 
    // if it has been sorted in ascending order 
    public static void UnitTestCase03()
    {

        // declare local variables 
        List<int> sequence;
        int[] unsortedArray; 

        // generates an unsorted array 
        unsortedArray = GenerateUnsortedArray(100);

        // sorts the array using the PancakeFlip method 
        sequence = PancakeFlip(unsortedArray); 

    }

    // Unit Test Case 04
    // randomly generates an unsorted array of integers with a size between 2 - maxSize 
    // calls the overload PancakeFlip method, which gets the sequence, and then 
    // performs the PancakeFlip on the unsorted Array, to sort the array, and then 
    // verifies that the array is sorted in ascending order, and saves to the file 
    // if it has been sorted in ascending order 
    public static void UnitTestCase04()
    {

        // declare local variables 
        int[] unsortedArray;

        // generates an unsorted array 
        unsortedArray = GenerateUnsortedArray(100);

        // sorts the array using the PancakeFlip method 
        PancakeFlip(unsortedArray);

    }

}
