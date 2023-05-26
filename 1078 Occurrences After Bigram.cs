public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] words = text.Split(" ");
        List<string> ans = new ();
        for (int i = 0; i < words.Length - 2; i++)
            if (words[i] == first && words[i + 1] == second)
                ans.Add(words[i + 2]);
        return ans.ToArray();
    }
}