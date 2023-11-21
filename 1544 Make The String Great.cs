public class Solution {
    public string MakeGood(string s) {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < sb.Length - 1; i++)
        {
            if (sb[i] - 32 == sb[i + 1] || sb[i] + 32 == sb[i + 1])
            {
                sb.Remove(i, 2);
                i = -1;
            }
        }
        return sb.ToString();
    }
}