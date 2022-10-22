public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        int i = 0;
        int id = n;
        int max = 0;
        
        while (i < logs.Length)
        {
            if (i == 0)
            {
                id = logs[i][0];
                max = logs[i][1];
            }
            else if (logs[i][1] - logs[i - 1][1] > max || (logs[i][1] - logs[i - 1][1] == max && logs[i][0] < id))
            {
                id = logs[i][0];
                max = logs[i][1] - logs[i - 1][1];
            }
                        
            i++;
        }
        
        return id;
    }
}