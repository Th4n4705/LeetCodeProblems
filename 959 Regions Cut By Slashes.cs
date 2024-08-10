public class Solution {
    public int RegionsBySlashes(string[] grid) {
        int ans = 0;
        int size = grid.Length * 3;
        bool[,] arr = new bool[size, size];
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
            {
                int r = i * 3;
                int c = j * 3;
                if (grid[i][j] == '/')
                {
                    arr[r, c + 2] = true;
                    arr[r + 1, c + 1] = true;
                    arr[r + 2, c] = true;
                }
                else if (grid[i][j] == '\\')
                {
                    arr[r, c] = true;
                    arr[r + 1, c + 1] = true;
                    arr[r + 2, c + 2] = true;
                }
            }
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
            {
                if (arr[i, j])
                    continue;
                DFS (i, j, arr);
                ans++;
            }
        return ans;
    }

    void DFS(int i, int j, bool[,] arr)
    {
        if (i < 0 || j < 0 || i >= arr.GetLength(0) || j >= arr.GetLength(1) || arr[i, j])
            return;
        arr[i, j] = true;
        DFS(i, j - 1, arr);
        DFS(i, j + 1, arr);
        DFS(i + 1, j, arr);
        DFS(i - 1, j, arr);
    }
}