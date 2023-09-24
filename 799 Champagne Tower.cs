public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[][] tower = new double[query_row + 1][];
        for (int i = 0; i <= query_row; i++)
            tower[i] = new double[i + 1];
        tower[0][0] = poured;
        for (int i = 0; i < query_row; i++)
            for (int j = 0; j < tower[i].Length; j++)
            {
                double rest = (tower[i][j] - 1) / 2.0;
                if (rest > 0)
                {
                    tower[i + 1][j] += rest;
                    tower[i + 1][j + 1] += rest;
                }
            }
        return Math.Min(1.0, tower[query_row][query_glass]);
    }
}