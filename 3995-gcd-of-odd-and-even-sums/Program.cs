public class Program {
    public int GcdOfOddEvenSums(int n)
    {
        if (n == 1)
            return 1;
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 1; i <= n; i++)
        {
            sumOdd += 2 * i - 1;
            sumEven += 2 * i;
        }
        return GcdEfficient(sumOdd, sumEven);
    }
    public int GcdEfficient(int first, int second)
    {
        while (second != 0)
        {
            int remainder = first % second;
            first = second;
            second = remainder;
        }
        return first;
    }
}