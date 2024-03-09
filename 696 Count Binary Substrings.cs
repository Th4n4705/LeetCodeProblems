public class Solution {
    public int CountBinarySubstrings(string s) {
        int sum = 0;
        int current = 1;
        int prev = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
                current++;
            else
            {
                prev = current;
                current = 1;
            }
            if (prev >= current)
                sum++;
        }
        return sum;
    }
}