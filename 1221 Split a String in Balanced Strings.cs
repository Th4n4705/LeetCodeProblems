public class Solution {
    public int BalancedStringSplit(string s) {
        int counter = 0;
        int l = 0;
        int r = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
                r++;
            else
                l++;
            if (r == l)
            {
                counter ++;
                l = 0;
                r = 0;
            }
        }
        return counter;
    }
}