public class Solution {
    public int FindTheLongestBalancedSubstring(string s) {
        int ans = 0;
        int i = 0;
        while (i < s.Length)
        {
            int zz = 0;
            int oo = 0;
            while (i < s.Length && s[i] == '0')
            {
                zz++;
                i++;
            }
            while (i < s.Length && s[i] == '1')
            {
                oo++;
                i++;
            }
            ans = Math.Max(ans, Math.Min(zz, oo));
        }
        return ans * 2;
    }
}