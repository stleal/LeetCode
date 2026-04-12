public class Program {
    public int FinalValueAfterOperations(string[] operations) {
        var result = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "--X":
                    result -= 1;
                    break;
                case "X--":
                    result -= 1;
                    break;
                case "++X":
                    result += 1;
                    break;
                case "X++":
                    result += 1;
                    break;
                default:
                    break;
            }
        }
        return result;
    }
}