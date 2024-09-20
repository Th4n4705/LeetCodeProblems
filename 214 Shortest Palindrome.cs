public class Solution {
    public string ShortestPalindrome(string s) {
        int left = 0;
        for (int right = s.Length - 1; right >= 0; right--)
            if (s[right] == s[left])
                left++;
        if (left == s.Length)
            return s;
        string restS = s.Substring(left);
        string reversedS = string.Join("", restS.Reverse());
        return reversedS + ShortestPalindrome(s.Substring(0, left)) + restS;
    }
}