public class Solution {
    public string DecodeAtIndex(string s, int k) {
        long l = 0;
        int i = 0;
        while (l < k)
        {
            if (char.IsDigit(s[i]))
                l *= s[i] - '0';
            else
                l++;
            i++;
        }
        for (int j = i - 1; j >= 0; j--)
        {
            if (char.IsDigit(s[j]))
            {
                l /= s[j] - '0';
                k %= (int)l;
            }
            else
            {
                if (k == 0 || k == l)
                    return s[j].ToString();
                l--;
            }
        }
        return string.Empty;
    }
}