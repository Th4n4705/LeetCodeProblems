public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new();
        while (n > 0)
        {
            sb.Insert(0, (char)(((n - 1) % 26) + 'A'));
            n = (n - 1) / 26;
        }
        return sb.ToString();
    }
}