public class Solution {
    public int DiagonalSum(int[][] mat) {
        int res = 0;
        int h = mat.Length;
        int m = mat[0].Length;
        for (int i = 0; i < h; i++)
            for (int j = 0; j < m; j++)
                if (i == j || (i + j) % (h - 1) == 0)
                    res += mat[i][j];
        return res;
    }
}