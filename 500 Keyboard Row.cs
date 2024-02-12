public class Solution {
    public string[] FindWords(string[] words) {
        char[] first = {'e', 'i', 'o', 'p', 'q', 'r', 't', 'u', 'w', 'y' };
        char[] second = {'a', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 's'};
        char[] third = {'b', 'c', 'm', 'n', 'v', 'x', 'z'};
        List<string> ls = new();
        foreach (string w in words)
        {
            HashSet<char> tmp = new HashSet<char>(w.ToLower().ToCharArray());
            if (tmp.IsSubsetOf(first) || tmp.IsSubsetOf(second) ||tmp.IsSubsetOf(third))
                ls.Add(w);
        }
        return ls.ToArray();
    }
}