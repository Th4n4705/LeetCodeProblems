public class Solution {
    public string ReplaceDigits(string s) {
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0' && s[i] <= '9')
                sb.Append(Convert.ToChar(s[i - 1] + Convert.ToInt32(s[i] - '0')));
            else
                sb.Append(s[i]);
        }
        return sb.ToString();
    }
}