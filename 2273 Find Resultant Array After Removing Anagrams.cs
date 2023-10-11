public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        List<string> ls = new();
        ls.Add(words[0]);
        for (int i = 1; i < words.Length; i++)
        {
            char[] less = words[i - 1].ToCharArray();
            Array.Sort(less);
            char[] same = words[i].ToCharArray();
            Array.Sort(same);
            string sLess = new string(less);
            string s = new string(same);
            if (s != sLess)
                ls.Add(words[i]);
        }
        return ls;
    }
}