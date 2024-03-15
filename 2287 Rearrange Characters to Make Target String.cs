public class Solution {
    public int RearrangeCharacters(string s, string target) {
        Dictionary<char, int> str = new();
        foreach (var c in s)
            if (!str.ContainsKey(c))
                str.Add(c, 1);
            else
                str[c]++;
        Dictionary<char, int> str1 = new();
        foreach (var c in target)
            if (!str1.ContainsKey(c))
                str1.Add(c, 1);
            else
                str1[c]++;
        int min = Int32.MaxValue;
        foreach (var c in target)
            if (str.ContainsKey(c))
                min = Math.Min(min, str[c] / str1[c]);
            else
                min = 0;
        return min;
    }
}