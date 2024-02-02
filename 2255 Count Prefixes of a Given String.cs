public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int counter = 0;
        foreach (string w in words)
            if (s.StartsWith(w))
                counter++;
        return counter;
    }
}