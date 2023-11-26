public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> ans = new ();
        for (int i = 0; i < words.Length; i++)
            if (words[i].Contains(x))
                ans.Add(i);
        return ans;
    }
}