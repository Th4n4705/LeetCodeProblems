public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        int ans = 0;
        int[] time = new int[timePoints.Count];
        for (int i = 0; i < timePoints.Count; i++)
            time[i] += (int.Parse(timePoints[i].Substring(0, 2)) * 60) + int.Parse(timePoints[i].Substring(3, 2));
        Array.Sort(time);
        ans = Math.Min (time[1] - time[0], time[0] - (time[time.Length - 1] - 1440));
        int r = time[1];
        for (int i = 2; i < time.Length; i++)
        {
            ans = Math.Min(ans, time[i] - r);
            r = time[i];
        }
        return ans;
    }
}