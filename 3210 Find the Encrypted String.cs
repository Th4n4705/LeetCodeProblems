public class Solution {
    public string GetEncryptedString(string s, int k) {
        int ind = k % s.Length;
        string ans = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (ind == s.Length)
                ind = 0;
            ans += s[ind++];
        }
        return ans;
    }
}