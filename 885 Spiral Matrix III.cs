public class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
        int length = rows * cols;
        int x = rStart;
        int y = cStart;
        int direction = 0;
        int ind = 0;
        int steps = 1;
        int[][] ans = new int[length][];
        int[][] arr = new int[][]{
           new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {-1, 0} 
        };
        ans[ind++] = new int[]{x, y};
        while (ind < length)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < steps; j++)
                {
                    x += arr[direction][0];
                    y += arr[direction][1];
                    if ( x >= 0 && x < rows && y >= 0 && y < cols)
                        ans[ind++] = new int[]{x, y};
                }
                direction = (direction + 1) % 4;
            }
            steps++;
        }
        return ans;
    }
}