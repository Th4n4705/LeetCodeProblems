public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] isChecked = new bool[s.Length];
        Array.Fill(isChecked, false);
        bool[] checkedValues = new bool[s.Length];
        Array.Fill(checkedValues, false);
        return Helper (0, isChecked, checkedValues, s, wordDict);
    }
    
    private bool Helper (int start, bool[] isChecked, bool[] checkedValues, string s, IList<string> wordDict)
    {
        if (isChecked[start])
            return checkedValues[start];
        foreach (string word in wordDict)
        {
            if (string.CompareOrdinal(s, start, word, 0, word.Length) == 0)
            {
                if (s.Length - start == word.Length)
                    return true;
                bool ans = Helper (start + word.Length, isChecked, checkedValues, s, wordDict);
                if (ans)
                    return true;
            }
        }
        isChecked[start] = true;
        checkedValues [start] = false;
        return false;
    }
}