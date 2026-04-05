/**********************************************************************************************************************
 * Name: Sam Leal 
 * Date: 11/25/2023 
 * Filename: RevealCards.cs 
 * Description: You are given an integer array deck. 
 * 
 * There is a deck of cards where every card has a unique integer. 
 * The integer on the ith card is deck[i]. 
 * 
 * You can order the deck in any order you want. 
 * Initially, all the cards start face down (unrevealed) in one deck. 
 * 
 * You will do the following steps repeatedly until all cards are revealed: 
 * 
 *  1) Take the top card of the deck, reveal it, and take it out of the deck. 
 *  2) If there are still cards in the deck then put the next top card of the deck at the bottom of the deck. 
 *  3) If there are still unrevealed cards, go back to step 1. Otherwise, stop. 
 * 
 * Return an ordering of the deck that would reveal the cards in increasing order. 
 * 
 * Note that the first entry in the answer is considered to be the top of the deck.
***********************************************************************************************************************/
public class Program
{

    // main 
    public static void Main(string[] args)
    {

        // declare local variables 
        int[] deck, permutedDeck;

        // initialize local variables 
        deck = new int[] { 6, 3, 2, 1, 3 }; 

        // put the Deck into the correct order 
        permutedDeck = PutCardsIntoTheCorrectOrder(deck); 

        // reveal the Deck in Increasing order 
        RevealDeckIncreasing(permutedDeck);

        // line-break 
        Console.WriteLine(); 

        // Unit Test Case 02 
        deck = new int[] { 6, 3, 2, 1, 3, 8, 12, 6, 5, 8, 13, 10, 7, 9, 4 };

        // put the Deck into the correct order 
        permutedDeck = PutCardsIntoTheCorrectOrder(deck);

        // reveal the Deck in Increasing order 
        RevealDeckIncreasing(permutedDeck);

        // line-break 
        Console.WriteLine();

        // Unit Test Case 03 
        deck = new int[] { 8, 7, 6, 5, 4, 3, 2, 1, 6, 5, 8, 10, 6, 9, 10, 4 };

        // put the Deck into the correct order 
        permutedDeck = PutCardsIntoTheCorrectOrder(deck);

        // reveal the Deck in Increasing order 
        RevealDeckIncreasing(permutedDeck);

        // line-break 
        Console.WriteLine();

        // stop 
        Console.ReadLine();

    } 

    // reveals the Deck in Increasing order 
    public static void RevealDeckIncreasing(int[] deck)
    {
        List<int> dealerHand; 
        dealerHand = deck.ToList(); 
        while (dealerHand.Count > 0)
        {
            Console.Write(dealerHand.ElementAt(0) + " ");
            dealerHand.RemoveAt(0); 
            if (dealerHand.Count > 0)
            {
                dealerHand.Add(dealerHand.ElementAt(0));
                dealerHand.RemoveAt(0);
            }
        }
    } 

    // returns an ordering of the Deck that shall reveal the cards in increasing order 
    public static int[] PutCardsIntoTheCorrectOrder(int[] deck)
    {

        // declare local variables 
        int[] permutedDeck; 
        List<int> dealerHand;

        // initialize local variables 
        dealerHand = new List<int>();
        permutedDeck = new int[deck.Length];

        // sort the Deck 
        BubbleSort(deck);

        // re-construct the Deck in the Permuted order 
        for (int i = deck.Length - 1; i >= 0; i--)
        {
            dealerHand.Add(deck[i]);
            if (i < deck.Length && i > 0)
            {
                dealerHand.Add(dealerHand.ElementAt(0));
                dealerHand.RemoveAt(0);
            }
        }

        // reverse the List<int> 
        dealerHand.Reverse();

        // copies the Permuted Deck into an int[] 
        dealerHand.CopyTo(permutedDeck);

        // return the Permuted Deck 
        return permutedDeck; 

    }

    // sorts an Array of Integers 
    public static void BubbleSort(int[] deck)
    {
        for (int i = 0; i < deck.Length; i++)
        {
            for (int j = 0; j <= deck.Length - 1; j++)
            {
                int swap; 
                if (deck[i] < deck[j])
                {
                    swap = deck[i];
                    deck[i] = deck[j];
                    deck[j] = swap;
                }
            }
        }
    }

} 
