public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int current = image[sr][sc];
        if (current != color)
            FillIt(image, sr, sc, color, current);
        return image;
    }

    void FillIt (int[][] m, int i, int j, int col, int curr)
    {
        if (m[i][j] == curr)
        {
            m[i][j] = col;
            if (i - 1 >= 0)
                FillIt(m, i - 1, j, col, curr);
            if (i + 1 < m.Length)
                FillIt(m, i + 1, j, col, curr);
            if (j - 1 >= 0)
                FillIt(m, i, j - 1, col, curr);
            if (j + 1 < m[0].Length)
                FillIt(m, i, j + 1, col, curr);
        }
    }
}