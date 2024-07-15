public class Solution {
    public string GetSmallestString(string s) {
        for (int i = 0; i < s.Length - 1; i++)
            if (s[i] > s[i + 1] && (s[i]-s[i+1]) % 2 == 0)
                return s.Substring(0, i) + s[i + 1] + s[i] + s.Substring(i + 2, s.Length - i - 2);
        return s;
    }
}