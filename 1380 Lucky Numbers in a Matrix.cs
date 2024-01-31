public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        List<int> ls = new();
        for (int i = 0; i < matrix.Length; i++)
        {
            int col = Array.IndexOf(matrix[i], matrix[i].Min());
            if (RowChecker(matrix, i, col) && ColumnChecker(matrix, i, col))
                ls.Add(matrix[i][col]);
        }
        return ls;
    }

    private bool RowChecker(int[][] m, int x, int y)
    {
        return m[x].Min() == m[x][y];
    }

    private bool ColumnChecker(int[][] m, int x, int y)
    {
        return m.Select(row => row[y]).Max() == m[x][y];
    }
}