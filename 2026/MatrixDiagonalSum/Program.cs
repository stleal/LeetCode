public class Solution {
    public int DiagonalSum(int[][] mat) {
        if (mat.GetLength(0) == 1)
            return mat[0][0];
        var sum = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
        }
        var row = mat.Length-1;
        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[row--][i];
        }
        if (mat.GetLength(0) % 2 == 1)
            sum -= mat[mat.GetLength(0)/2][mat.Length/2];
        return sum;
    }
}