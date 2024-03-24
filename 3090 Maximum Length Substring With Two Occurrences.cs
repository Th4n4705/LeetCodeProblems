public class Solution {
    public int MaximumLengthSubstring(string s) {
        int start = 0;
        int end = 0;
        int length = 0;
        int maxLen = int.MinValue;
        Dictionary<char, int> dc = new();
        for (; end < s.Length; end++)
        {
            if (dc.ContainsKey(s[end]))
                dc[s[end]]++;
            else
                dc.Add(s[end], 1);
            while (dc[s[end]] > 2)
            {
                dc[s[start]]--;
                start++;
            }
            length = end - start + 1;
            maxLen = Math.Max(maxLen, length);
        }
        return maxLen;
    }
}