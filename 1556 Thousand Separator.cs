public class Solution {
    public string ThousandSeparator(int n) {
        if (n < 1000)
            return n.ToString();
        string s = n.ToString();
        StringBuilder sb = new();
        int first = s.Length % 3;
        if (first != 0)
            sb.Append(s.Substring(0 , first));
        for (int i = first; i < s.Length; i = i + 3)
        {
            if (sb.ToString().Length != 0)
                sb.Append(".");
            sb.Append(s.Substring(i , 3));
        }
        return sb.ToString();
    }
}