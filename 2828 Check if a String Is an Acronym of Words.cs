public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        if (s.Length != words.Count)
            return false;
        for (int i = 0; i < s.Length; i++)
            if (words[i][0] != s[i])
                return false;
        return true;
    }
}