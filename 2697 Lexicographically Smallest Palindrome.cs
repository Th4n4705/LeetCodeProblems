public class Solution {
    public string MakeSmallestPalindrome(string s) {
        int y = s.Length - 1;
        int x = 0;
        char[] ch = s.ToArray();
        while (x < y)
        {
            if (s[x] < s[y])
                ch[y--] = ch[x++];
            else
                ch[x++] = ch[y--];
        }
        return new string(ch);
    }
}