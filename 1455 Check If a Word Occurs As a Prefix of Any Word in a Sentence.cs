public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var s = sentence.Split(" ");
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Contains(searchWord) && s[i].Substring(0, searchWord.Length) == searchWord)
                return i + 1;
        }
        return -1;
    }
}