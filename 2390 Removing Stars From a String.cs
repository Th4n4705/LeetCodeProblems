public class Solution {
    public string RemoveStars(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (var ch in s)
        {
            if (ch != '*')
                sb.Append(ch);
            else
                sb.Remove(sb.Length - 1, 1);
        }
        return sb.ToString();
    }
}