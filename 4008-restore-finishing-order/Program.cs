public class Program {
    public int[] RecoverOrder(int[] order, int[] friends) {
        int count = 0;
        int[] ans = new int[friends.Length];
        for (int i = 0; i < order.Length; i++) 
        {
            for (int j = 0; j < friends.Length; j++)
            {
                if (order[i] == friends[j])
                {
                    ans[count++] = order[i];
                    break;
                }
            }
        }
        return ans;
    }
}