public class Solution {
    public int[] CountBits(int n) {
        var num = n + 1;
        int[] ans = new int[num];
        for (int i = 0; i < num; i++)
        {
            var binary = ConvertToBinary(i);
            var count = binary.Count(x => x == '1');
            ans[i] = count;
        }
        return ans;
    }

    private static string ConvertToBinary(int num)
    {
        var sum = 0;
        var result = string.Empty;
        var logBase = (int)Math.Log(num, 2);
        var numberOfBits = logBase + 1;
        for (int i = numberOfBits-1; i >=0; i--)
        {
        var x = Math.Pow(2, i);
        result = (!(sum + x > num)) ? result + "1" : result + "0";
        sum += (IsLastCharOne(result)) ? (int)x : 0;
        }
        return result;
    }

    private static bool IsLastCharOne(string result)
    {
        return result[result.Length - 1] == '1';
    }
}