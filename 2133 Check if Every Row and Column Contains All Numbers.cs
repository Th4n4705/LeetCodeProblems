public class Solution {
    public bool CheckValid(int[][] matrix) {
        bool[] checker = new bool[matrix.Length];
        foreach (int[] row in matrix)
        {
            foreach (int c in row)
                checker[c - 1] = true;
            if (checker.Any(n => n == false))
                return false;
            checker = new bool[matrix.Length];
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
                checker[matrix[j][i] - 1] = true;
            if (checker.Any(n => n == false))
                return false;
            checker = new bool[matrix.Length];
        }
        return true;
    }
}