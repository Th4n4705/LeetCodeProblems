public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s == null || t == null)
            return false;
        int i = 0;
        int j = 0;
        while (i < s.Length)
        {
            while (j < t.Length && s[i] != t[j])
                j++;
            if (j == t.Length)
                break ;
            i++;
            j++;
        }
        return i == s.Length;
    }
}