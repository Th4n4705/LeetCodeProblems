public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals.Length <= 1)
            return 0;
        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
        int counter = 0;
        int end = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
            if (intervals[i][0] < end)
                counter++;
            else
                end = intervals[i][1];
        return counter;
    }
}