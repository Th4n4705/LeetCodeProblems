public class Solution {
    private int CheckCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }

    public string LongestPalindrome(string s) {
        if (s == null || s == string.Empty)
            return "";
        int palStart = 0;
        int palEnd = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len = CheckCenter(s, i, i);
            int len2 = CheckCenter(s, i, i + 1);
            len = Math.Max(len, len2);
            if (len > palEnd - palStart)
            {
                palStart = i - (len - 1) / 2;
                palEnd = i + len / 2;
            }
        }
        return s.Substring(palStart, palEnd - palStart + 1);
    }
}