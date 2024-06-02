public class Solution {
    public int MinimumChairs(string s) {
        int waiting = 0;
        int ans = 0;
        foreach (char c in s)
        {
            if (c == 'E')
                waiting++;
            else
                waiting--;
            if (ans < waiting)
                ans = waiting;
        }
        return ans;
    }
}