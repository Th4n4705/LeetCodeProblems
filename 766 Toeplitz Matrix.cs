public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        for (int i = 0; i < matrix.Length - 1; i++)
            for (int j = 0; j < matrix[i].Length - 1; j++)
                if (matrix[i][j] != matrix[i + 1][j + 1])
                    return false;
        return true;
    }
}