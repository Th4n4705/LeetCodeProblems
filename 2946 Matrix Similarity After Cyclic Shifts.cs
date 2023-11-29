public class Solution {
    public bool AreSimilar(int[][] mat, int k) {
        k = k % mat[0].Length;
        if (k == 0)
            return true;
        for (int i = 0; i < mat.Length; i++)
        {
            int col = (i % 2 == 1) ? mat[0].Length - k : k;
            for (int j = 0; j < mat[i].Length; j++, col = (col + 1) % mat[i].Length)
                if (mat[i][j] != mat[i][col])
                    return false;
        }
        return true;
    }
}