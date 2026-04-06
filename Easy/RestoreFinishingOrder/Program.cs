/***************************************************************************************************************
 * Name: Sam Leal
 * Date: 04/06/2026
 * Description: Given an array of integers order and an array of integers friends, return an array of integers
 * representing the order of the friends in the order array.
 *
 * Example 1:
 * Input: order = [3,1,2,4,5], friends = [3,1,4]
 * Output: [3,1,4]
 * Explanation: The order of the friends in the order array is [3,1,4].
 *************************************************************************************************************/
public class Program {
    public static void Main(string[] args)
    {
      int[] order = new int[] { 3, 1, 2, 4, 5 };
      int[] friends = new int[] { 3, 1, 4 };
      int[] ans = RecoverOrder(order, friends);
    }

    public static int[] RecoverOrder(int[] order, int[] friends) {
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