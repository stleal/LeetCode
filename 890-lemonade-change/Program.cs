public class Program {
    public bool LemonadeChange(int[] bills) {
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