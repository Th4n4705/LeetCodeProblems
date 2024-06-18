public class Solution {
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter) {
        int[][] ans = new int[rows * cols][];
        int[][] dist = new int[rows * cols][];
        for (int i = 0, j = 0; i < rows; i++)
            for (int k = 0; k < cols; j++, k++)
                dist[j] = new int[] {i, k, Math.Abs(i - rCenter) + Math.Abs(k - cCenter)};
        Array.Sort(dist, (a, b) => a[2] - b[2]);
        for (int i = 0; i < rows * cols; i++)
            ans[i] = new int[] {dist[i][0], dist[i][1]};
        return ans;
    }
}