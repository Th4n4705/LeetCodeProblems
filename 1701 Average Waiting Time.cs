public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        double totalWait = .0;
        int time = 0;
        foreach (int[] c in customers)
        {
            if (time < c[0])
                time = c[0];
            time += c[1];
            totalWait += time - c[0];
        }
        return totalWait / customers.Length;
    }
}