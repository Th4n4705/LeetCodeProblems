public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int max = 0;
        int index = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            int val = 0;
            for (int j = 0; j < mat[0].Length; j++)
                if (mat[i][j] == 1)
                    val++;
            if (val > max)
            {
                index = i;
                max = val;
            }
        }
        return new int[] {index, max};
    }
}