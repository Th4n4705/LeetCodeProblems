public class Solution {
    public int MinOperations(string s) {
        int exp = 0;
        int operation = 0;
        foreach (char ch in s)
        {
            if (exp != ch - '0')
                operation++;
            exp = 1 - exp;
        }
        return Math.Min(operation, s.Length - operation);
    }
}