public class Solution {
    public bool ValidPalindrome(string s) {
        if (s.Length < 2)
            return true;
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return IsAPalindrome(s, left + 1, right) || IsAPalindrome(s, left, right - 1);
            left++;
            right--;
        }
        return true;
    }

    bool IsAPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}