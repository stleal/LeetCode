public class Solution {
    public int DiagonalSum(int[][] mat) {
        if (mat.GetLength(0) == 1)
            return mat[0][0];
        var sum = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
        }
        var col = mat.Length-1;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            sum += mat[i][col--];
        }
        if (mat.GetLength(0) % 2 == 1)
            sum -= mat[mat.GetLength(0)/2][mat.Length/2];
        return sum;
    }
}