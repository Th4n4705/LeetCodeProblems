public class Solution {
    public int MaxScore(string s) {
        int zeros = 0;
        int ones = 0;
        int maximum = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0')
                zeros++;
            for (int j = s.Length - 1; j > i; j--)
                if (s[j] == '1')
                    ones++;
            if (zeros + ones > maximum)
                maximum = zeros + ones;
            ones = 0;
        }
        return ones == s.Length || zeros == s.Length ? s.Length - 1 : maximum;
    }
}