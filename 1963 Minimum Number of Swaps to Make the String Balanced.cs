public class Solution {
    public int MinSwaps(string s) {
        int open = 0;
        int neg = 0;
        foreach (char c in s)
            if (c == '[')
                open++;
            else
            {
                if (open > 0)
                    open--;
                else
                    neg++;
            }
        return (neg + 1) / 2;
    }
}