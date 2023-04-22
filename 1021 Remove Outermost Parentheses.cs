public class Solution {
    public string RemoveOuterParentheses(string s) {
        StringBuilder sb = new();
        int sign = 0;
        foreach (var ch in s)
        {
            sign += ch =='(' ? 1 : -1;
            if (ch == '(' && sign > 1 || ch == ')' && sign > 0)
                sb.Append(ch);
        }
        return sb.ToString();
    }
}