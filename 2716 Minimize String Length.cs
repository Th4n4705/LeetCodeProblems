public class Solution {
    public int MinimizedStringLength(string s) {
        Dictionary<char, int> dc = new ();
        for (int i = 0; i < s.Length; i++)
            if (!dc.ContainsKey(s[i]))
                dc.Add(s[i], 1);
            else
                dc[s[i]]++;
        return dc.Count;
    }
}