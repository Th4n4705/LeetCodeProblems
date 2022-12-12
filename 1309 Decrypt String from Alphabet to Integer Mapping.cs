public class Solution {
    public string FreqAlphabets(string s) {
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 2 < s.Length && s[i + 2] == '#')
            {
                sb.Append(Convert.ToChar('a' + (Convert.ToInt32(s.Substring(i, 2)) - 1)));
                i = i + 2;
            }
            else
                sb.Append(Convert.ToChar('a' + Convert.ToInt32(s.Substring(i, 1)) - 1));
        }
        return sb.ToString();
    }
}