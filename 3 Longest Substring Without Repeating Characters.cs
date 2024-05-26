public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length < 2)
            return s.Length;
        int max = 0;
        int counter = 0;
        int k = 0;
        for (int i = 1; i < s.Length; i++)
        {
            for (int j = k; j < i; j++)
                if (s[i] == s[j])
                    k = j + 1;
            counter = i - k + 1;
            if (counter > max)
                max = counter;
        }
        return max;
    }
}