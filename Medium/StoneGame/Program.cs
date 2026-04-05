/********************************************************************************************************************************
 * Name: Sam Leal 
 * Date: 11/26/2023 
 * Filename: StoneGame.cs 
 * Description: Alice and Bob play a game with piles of stones. There are an even number of piles arranged in a row, and 
 * each pile has a positive integer number of stones piles[i]. The objective of the game is to end with the most stones. 
 * 
 * The total number of stones across all the piles is odd, so there are no ties. 
 * Alice and Bob take turns, with Alice starting first. Each turn, a player takes the entire pile of stones either from the 
 * beginning or from the end of the row. This continues until there are no more piles left, at which point the person with the 
 * most stones wins. 
 * 
 * Assuming Alice and Bob play optimally, return true if Alice wins the game, or false if Bob wins. 
 *  
 * Constraints: 
 *  
 *  1) 2 <= piles.length <= 500 
 *  2) piles.length is even. 
 *  3) 1 <= piles[i] <= 500 
 *  4) sum(piles[i]) is odd. 
 *  
*********************************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] piles;

        // initialize local variables 
        piles = new int[] { 5, 3, 4, 5 };

        // play Game 
        Console.WriteLine("Is Alice the Winner?: " + StoneGame(piles));

        // Unit Test Case 02
        // sum = 103, length = 16, odd sum, even length 
        piles = new int[] { 5, 3, 4, 5, 4, 6, 9, 2, 1, 8, 3, 10, 7, 11, 12, 13 }; 

        // play Game 
        Console.WriteLine("Is Alice the Winner?: " + StoneGameWithHelperMethodsForDebugging(piles));

        // stop 
        Console.ReadLine(); 

    } 

    // stone Game 
    public static bool StoneGame(int[] piles)
    {

        // declare local variables 
        int turn, stone;
        int choice, index; 
        List<int> pilesList;
        Random r = new Random(); 
        int alicePoints, bobPoints;

        // initialize local variables 
        turn = -1;
        r = new Random();
        pilesList = piles.ToList();
        alicePoints = bobPoints = 0;

        // take Turns 
        while (pilesList.Count > 0)
        {
            choice = r.Next(0, 2); 
            stone = (choice == 0) ? pilesList[0] : pilesList[pilesList.Count - 1];
            alicePoints += (turn == -1) ? stone : 0;
            bobPoints += (turn == 1) ? stone : 0;
            index = (choice == 0) ? 0 : pilesList.Count - 1;
            pilesList.RemoveAt(index);
            turn *= -1; 
        }

        // return the winner 
        return (alicePoints >  bobPoints) ? true : false; 

    }

    // stone Game 
    public static bool StoneGameWithHelperMethodsForDebugging(int[] piles)
    {

        // declare local variables 
        int turn, stone;
        int choice, index;
        List<int> pilesList;
        Random r = new Random();
        int alicePoints, bobPoints;
        List<int> alicePileList, bobPileList;

        // initialize local variables 
        turn = -1;
        r = new Random();
        pilesList = piles.ToList();
        alicePoints = bobPoints = 0;
        alicePileList = new List<int>(); 
        bobPileList = new List<int>(); 

        // take Turns 
        while (pilesList.Count > 0)
        {
            choice = r.Next(0, 2);
            stone = (choice == 0) ? pilesList[0] : pilesList[pilesList.Count - 1]; 
            alicePoints += (turn == -1) ? stone : 0;
            bobPoints += (turn == 1) ? stone : 0;
            index = (choice == 0) ? 0 : pilesList.Count - 1;
            if (turn == -1)
            {
                alicePileList.Add(stone); 
            } 
            else if (turn == 1)
            {
                bobPileList.Add(stone); 
            }
            pilesList.RemoveAt(index);
            turn *= -1;
        }

        // print each player's pile of Stones 
        PrintPoints(alicePileList, bobPileList); 

        // return the winner 
        return (alicePoints > bobPoints) ? true : false;

    }

    // prints each player's pile of Stones 
    public static void PrintPoints(List<int> alicePileList, List<int> bobPileList)
    {

        // declare local variables 
        int sum;

        // initialize local variables 
        sum = 0; 

        // Alice's points 
        Console.Write("Alice's Stones: ");
        foreach (int aliceStone in alicePileList)
        {
            Console.Write(aliceStone + ", ");
            sum += aliceStone;
        }
        Console.WriteLine();
        Console.WriteLine("Alice's Total Points: " + sum);

        // Bob's points 
        sum = 0;
        Console.Write("Bob's Stones: ");
        foreach (int bobStone in bobPileList)
        {
            Console.Write(bobStone + ", ");
            sum += bobStone;
        }
        Console.WriteLine();
        Console.WriteLine("Bob's Total Points: " + sum);

    }

} 
