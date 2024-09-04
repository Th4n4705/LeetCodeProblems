public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        int x = 0;
        int y = 0;
        int index = 0;
        int ans = 0;
        int[,] directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        Dictionary<(int, int), bool> obstaclesArr = new();
        foreach (int[] o in obstacles)
            obstaclesArr[(o[0], o[1])] = true;
        foreach (int c in commands)
            if (c == -1)
                index = (index + 1) % 4;
            else if (c == -2)
                index = (index + 3) % 4;
            else
            {
                for (int i = 0; i < c; i++)
                {
                    int X = x + directions[index, 0];
                    int Y = y + directions[index, 1];
                    if (!obstaclesArr.ContainsKey((X, Y)))
                    {
                        x = X;
                        y = Y;
                        ans = Math.Max(ans, x * x + y * y);
                    }
                    else
                        break;
                }
            }
        return ans;
    }
}