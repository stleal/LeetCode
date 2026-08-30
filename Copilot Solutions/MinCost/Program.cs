public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MinCost(2));
        Console.WriteLine(MinCost(3));
    }

    public static int MinCost(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 0;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = int.MaxValue;
            for (int a = 1; a < i; a++)
            {
                int b = i - a;
                dp[i] = Math.Min(dp[i], dp[a] + dp[b] + a * b);
            }
        }

        return dp[n];
    }
}
