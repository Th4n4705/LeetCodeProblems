public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> dc = new();
        int ans = 0;
        foreach (int n in nums)
            if (!dc.ContainsKey(n))
                dc.Add(n, 1);
            else
                dc[n]++;
        int max = dc.Values.Max();
        foreach (int n in dc.Values)
            if (n == max)
                ans += max;
        return ans;
    }
}