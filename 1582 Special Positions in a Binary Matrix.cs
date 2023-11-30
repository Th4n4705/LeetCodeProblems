public class Solution {
    private bool SpecialOne (int[][] mat, int i, int j)
    {
        for (int k = 0; k < mat.Length; k++)
            if (mat[k][j] == 1 && k != i)
                return false;
        for (int k = 0; k < mat[0].Length; k++)
            if (mat[i][k] == 1 && k != j)
                return false;
        return true;
    }

    public int NumSpecial(int[][] mat) {
        int counter = 0;
        for (int i = 0; i < mat.Length; i++)
            for (int j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1 && SpecialOne(mat, i, j))
                    counter++;
        return counter;
    }
}