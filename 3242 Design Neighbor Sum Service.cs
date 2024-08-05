public class neighborSum {
    Dictionary<int, int> adjSum;
    Dictionary<int, int> diagSum;

    public neighborSum(int[][] grid) {
        adjSum = new Dictionary<int, int>();
        diagSum = new Dictionary<int, int>();
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
            {
                int n = grid[i][j];
                adjSum.Add(n, 0);
                diagSum.Add(n, 0);
                adjSum[n] += i - 1 >= 0 ? grid[i - 1][j] : 0;
                adjSum[n] += i + 1 < grid.Length ? grid[i + 1][j] : 0;
                adjSum[n] += j - 1 >= 0 ? grid[i][j - 1] : 0;
                adjSum[n] += j + 1 < grid.Length ? grid[i][j + 1] : 0;

                diagSum[n] += i + 1 < grid.Length && j + 1 < grid.Length  ? grid[i + 1][j + 1] : 0;
                diagSum[n] += i + 1 < grid.Length && j - 1 >= 0 ? grid[i + 1][j - 1] : 0;
                diagSum[n] += i - 1 >= 0 && j - 1 >= 0 ? grid[i - 1][j - 1] : 0;
                diagSum[n] += i - 1 >= 0 && j + 1 < grid.Length ? grid[i - 1][j + 1] : 0;

            }
    }
    
    public int AdjacentSum(int value) {
        return adjSum[value];
    }
    
    public int DiagonalSum(int value) {
        return diagSum[value]; 
    }
}

/**
 * Your neighborSum object will be instantiated and called as such:
 * neighborSum obj = new neighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */