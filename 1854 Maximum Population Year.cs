public class Solution {
    public int MaximumPopulation(int[][] logs) {
        int[] year = new int[101];
        for (int i = 0; i < logs.GetLength(0); i++)
        {
            year[logs[i][0] -1950]++;
            year[logs[i][1] -1950]--;
        }
        int max = 1;
        for (int i = 1; i < 101; i++)
        {
            year[i] = year[i] + year[i - 1];
            max = Math.Max(max, year[i]);
        }
        for (int i = 0; i < 101; i++)
            if (year[i] == max)
                return i + 1950;
        return 0;
    }
}