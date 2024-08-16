public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int min = int.MaxValue;
        int max = int.MinValue;
        int ans = 0;
        for (int i = 0; i < arrays.Count; i++)
        {
            int curMin = arrays[i][0];
            int curMax = arrays[i][arrays[i].Count - 1];
            if (i > 0)
            {
                ans = Math.Max(ans, Math.Abs(curMax - min));
                ans = Math.Max(ans, Math.Abs(max - curMin));
            }
            min = Math.Min(min, curMin);
            max = Math.Max(max, curMax);
        }
        return ans;
    }
}