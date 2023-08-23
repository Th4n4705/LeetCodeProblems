public class Solution {
    public string ReorganizeString(string s) {
        char[] ans = new char[s.Length];
        Dictionary<char, int> charsFreq = new ();
        foreach (char ch in s)
            if (charsFreq.ContainsKey(ch))
                charsFreq[ch]++;
            else
                charsFreq.Add(ch, 1);
        int maxFrequentLetter = charsFreq.Max(ch => ch.Value);
        if (maxFrequentLetter > (s.Length + 1) / 2)
            return "";
        char theFrequent = charsFreq.First(ch => ch.Value == maxFrequentLetter).Key;
        int k = 0;
        for (int i = 0; i < maxFrequentLetter; i++, k += 2)
            ans[k] = theFrequent;
        bool IsSecond = false;
        foreach (var item in charsFreq)
        {
            if (item.Key != theFrequent)
            {
                for (int i = 0; i < item.Value; i++, k += 2)
                {
                    if (k >= s.Length && !IsSecond)
                    {
                        IsSecond = true;
                        k = 1;
                    }
                    ans[k] = item.Key;
                }
            }
        }
        return new string(ans);
    }
}