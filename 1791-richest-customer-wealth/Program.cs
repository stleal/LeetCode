public class Program {
    public int MaximumWealth(int[][] accounts) {
        var maxWealth = 0;
        var sum = 0;
        foreach (var dimension in accounts)
        {
            for (int j = 0; j < dimension.Length; j++)
            {
                sum += dimension[j];
            }
            maxWealth = (sum >= maxWealth) ? sum : maxWealth;
            sum = 0;
        }
        return maxWealth;
    }
}