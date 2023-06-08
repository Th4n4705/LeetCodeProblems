public class Solution {
    public int CountNegatives(int[][] grid) {
        int counter = 0;
        foreach (var g in grid)
            for (int i = 0; i < g.Length; i++)
                if (g[i] < 0)
                {
                    counter += g.Length - i;
                    break;
                }
        return counter;
    }
}