public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
            return false;
        int[] S = new int[128];
        int[] T = new int[128];
        for (int i = 0; i < s.Length; i++)
            if (S[s[i]] == 0 && T[t[i]] == 0)
            {
                S[s[i]] = t[i];
                T[t[i]] = s[i];
            }
            else if (S[s[i]] != t[i] || T[t[i]] != s[i])
                return false;
        return true;
    }
}