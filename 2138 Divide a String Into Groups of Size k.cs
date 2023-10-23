public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        StringBuilder sb = new();
        sb.Length = k;
        int length = (int)Math.Ceiling((double)s.Length /k);
        string[] ans = new string[length];
        for (int i = 0; i < length; i++)
        {
            int curr = i * k;
            for (int j = curr; j < curr + k; j++)
                sb[j % k] = j < s.Length ? s[j] : fill;
            ans[i] = sb.ToString();
        }
        return ans;
    }
}