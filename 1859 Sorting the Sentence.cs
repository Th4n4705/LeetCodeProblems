public class Solution {
    public string SortSentence(string s) {
        string[] str = s.Split(' ');
        string[] ans = new string[str.Length];
        for (int i = 0; i < str.Length; i++)
            ans[(str[i][str[i].Length - 1] + '0' - 96) - 1] = str[i].Substring(0, str[i].Length - 1);
        return string.Join(' ', ans);
    }
}