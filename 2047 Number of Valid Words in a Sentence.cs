using System.Text.RegularExpressions;
public class Solution {
    public int CountValidWords(string sentence) {
        int ans = 0;
        string[] words = sentence.Split(' ');
        Regex reg = new(@"^([a-z]+(-?[a-z]+)?)?(!|\.|,)?$");
        foreach (string s in words)
            if (!string.IsNullOrEmpty(s) && reg.Match(s).Success)
                ans++;
        return ans;
    }
}