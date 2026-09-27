public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var count = 0;
        var counter = 0;
        Dictionary<char, int> distinctList = new Dictionary<char, int>();
        for (int i = 0; i < stones.Length; i++)
        {
            for (int j = 0; j < jewels.Length; j++)
            {
                if (jewels[j].Equals(stones[i]))
                {
                    var c = jewels[j];
                    distinctList.TryGetValue(c, out count);
                    if (count == 0)
                        distinctList.Add(jewels[j], 1);
                    counter++;
                }
            }
        }
        return counter;
    }
}