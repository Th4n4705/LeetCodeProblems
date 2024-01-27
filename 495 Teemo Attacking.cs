public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int counter = 0;
        for (int i = 1; i < timeSeries.Length; i++)
            if (timeSeries[i] - timeSeries[i - 1] > duration)
                counter += duration;
            else
                counter += timeSeries[i] - timeSeries[i - 1];
        counter += duration;
        return counter;
    }
}