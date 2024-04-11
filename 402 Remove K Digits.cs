public class Solution {
    public string RemoveKdigits(string num, int k) {
        if (num.Length <= k)
            return "0";
        StringBuilder sb = new();
        int d = k;
        foreach (char c in num)
        {
            while (d > 0 && sb.Length > 0 && sb[sb.Length - 1] > c)
            {
                sb.Remove(sb.Length - 1, 1);
                d--;
            }
            sb.Append(c);
        }
        while (d > 0)
        {
            sb.Remove(sb.Length - 1, 1);
            d--;
        }
        while (sb.Length > 1 && sb[0] == '0')
            sb.Remove(0, 1);
        return sb.ToString();
    }
}