public class Solution {
    public bool AreOccurrencesEqual(string s) {
        Dictionary<char, int> dc = new();
        for (int i = 0; i < s.Length; i++)
            if (dc.ContainsKey(s[i]))
                dc[s[i]]++;
            else
                dc.Add(s[i], 1);
        int witness = dc[s[0]];
        for (int i = 0; i < s.Length; i++)
            if (dc[s[i]] != witness)
                return false;
        return true;
    }
}