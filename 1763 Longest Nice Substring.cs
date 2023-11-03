public class Solution {
    public string LongestNiceSubstring(string s) {
        if (s.Length == 1)
            return "";
        
        HashSet<char> hs = new(s);
        for (int i = 0; i < s.Length; i++)
            if (!hs.Contains(char.ToUpper(s[i])) || !hs.Contains(char.ToLower(s[i])))
            {
                string left = LongestNiceSubstring(s.Substring(0, i));
                string right = LongestNiceSubstring(s.Substring(i + 1, s.Length - i - 1));
                return left.Length >= right.Length ? left : right;
            }
        return s;
    }
}