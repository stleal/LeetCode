/****************************************************************************
 * Name: Sam Leal
 * Date: 04/09/2026
 * Filename: Program.cs
 * Description: At a lemonade stand, each lemonade costs $5. Customers are
 * standing in a queue to buy lemonade, and each one buys exactly one cup.
 * They can only pay with a $5, $10, or $20 bill. Change is needed when a
 * customer presents either a $10 or $20 bill, and change can only be given
 * if the owner has received enough revenue. Return true if you can provide
 * every customer with correct change, or false otherwise.
 *
 * Example 1:
 * Input: bills = [5,5,5,10,20]
 * Output: true
 *
 * Example 2:
 * Input: bills = [5,5,10,10,20]
 * Output: false
 *
 * Constraints:
 * 1 <= bills.length <= 10^5
 * bills[i] is either 5, 10, or 20.
 ****************************************************************************/
public class Program
{
    public static void Main(string[] args)
    {
        // Example 1: expected true
        int[] bills1 = [5, 5, 5, 10, 20];
        Console.WriteLine(LemonadeChange(bills1));

        // Example 2: expected false
        int[] bills2 = [5, 5, 10, 10, 20];
        Console.WriteLine(LemonadeChange(bills2));
    }

    public static bool LemonadeChange(int[] bills)
    {
        // Track how many $5 and $10 bills we have on hand
        // Begin revenue at zero dollars (represented by fives and tens counts)
        int fives = 0;
        int tens = 0;

        for (int i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                // No change needed
                fives++;
            }
            else if (bills[i] == 10)
            {
                // Change is needed: give back one $5 bill
                if (fives == 0)
                {
                    return false;
                }
                fives--;
                tens++;
            }
            else
            {
                // bills[i] == 20
                // Change is needed: give back $15
                // Prefer to use a $10 + $5 (preserves more $5s for future use)
                if (tens > 0 && fives > 0)
                {
                    tens--;
                    fives--;
                }
                else if (fives >= 3)
                {
                    fives -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}
