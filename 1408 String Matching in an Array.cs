public class Solution {
    public IList<string> StringMatching(string[] words) {
        IList<string> s = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i != j && words[i].Contains(words[j]))
                    s.Add(words[j]);
            }
        }
        s = s.Distinct().ToList();
        return s;
    }
}