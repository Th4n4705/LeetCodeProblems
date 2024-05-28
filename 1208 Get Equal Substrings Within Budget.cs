public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int max = 0;
        int current = 0;
        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            current += Math.Abs(s[r] - t[r]);
            while (current > maxCost)
            {
                current -= Math.Abs(s[l] - t[l]);
                l++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}