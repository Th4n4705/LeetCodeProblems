public class Solution {
    public bool IsSubstringPresent(string s) {
        HashSet<(char, char)> hs = new();
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
                return true;
            hs.Add((s[i], s[i - 1]));
        }
        for (int i = 1; i < s.Length; i++)
            if (hs.Contains((s[i - 1], s[i])))
                return true;
        return false;
    }
}