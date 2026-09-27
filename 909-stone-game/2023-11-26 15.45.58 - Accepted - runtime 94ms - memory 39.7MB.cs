/************************************* 
 * Name: Sam Leal 
 * Date: 11/26/2023 
 * Filename: StoneGame.cs 
 ************************************/
public class Solution {

    public bool StoneGame(int[] piles) {

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
        return true; 

    }   

}
