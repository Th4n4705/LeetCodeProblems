public class Solution {
    public string SortString(string s) {
        int[] n = new int[26];
        StringBuilder sb = new();
        foreach (char c in s)
            n[c - 'a']++;
        while (sb.Length < s.Length)
        {
            for (int i = 0; i < n.Length; i++)
                if (n[i] > 0)
                {
                    sb.Append((char)('a' + i));
                    n[i]--;
                }
            for (int i = n.Length - 1; i >= 0; i--)
                if (n[i] > 0)
                {
                    sb.Append((char)('a' + i));
                    n[i]--;
                }
        }
        return sb.ToString();
    }
}