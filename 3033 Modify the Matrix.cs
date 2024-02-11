public class Solution {
    public int[][] ModifiedMatrix(int[][] matrix) {
        for (int i = 0; i < matrix[0].Length; i++)
        {
            int max = -1;
            for (int j = 0; j < matrix.Length; j++)
                max = Math.Max(max, matrix[j][i]);
            for (int j = 0; j < matrix.Length; j++)
                if (matrix[j][i] == -1)
                    matrix[j][i] = max;
        }
        return matrix;
    }
}