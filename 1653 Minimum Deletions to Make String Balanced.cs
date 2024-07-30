public class Solution {
    public int MinimumDeletions(string s) {
        int[] l = new int[s.Length];
        int[] r = new int[s.Length];
        l[0] = s[0] == 'b' ? 1 : 0;
        r[s.Length - 1] = s[s.Length - 1] == 'b' ? 0 : 1;
        for (int i = 1; i < s.Length; i++)
            l[i] = l[i - 1] + (s[i] == 'b' ? 1 : 0);
        for (int i = s.Length - 2; i >= 0; i--)
            r[i] = r[i + 1] + (s[i] == 'b' ? 0 : 1);
        int min = Math.Min(l[s.Length - 1], r[0]);
        for (int i = 0; i < s.Length - 1; i++)
            min = Math.Min(min, l[i] + r[i + 1]);
        return min;
    }
}