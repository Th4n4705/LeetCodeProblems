public class Solution {
    public int MinLength(string s) {
        int len = s.Length;
        while (true)
        {
            s = s.Replace("AB", "");
            s = s.Replace("CD", "");
            if (s.Length == len)
                return s.Length;
            len = s.Length;
        }
        return len;
    }
}