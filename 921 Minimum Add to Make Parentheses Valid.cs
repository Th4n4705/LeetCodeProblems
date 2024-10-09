public class Solution {
    public int MinAddToMakeValid(string s) {
        int open = 0;
        int close = 0;
        foreach (char c in s)
            if (c == '(')
                open++;
            else if (c == ')' && open > 0)
                open--;
            else
                close++;
        return open + close;
    }
}