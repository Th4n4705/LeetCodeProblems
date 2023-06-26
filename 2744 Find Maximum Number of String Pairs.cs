public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int pairs = 0;
        Dictionary<string, int> dc = new();
        foreach (string word in words)
            if (dc.ContainsKey(word))
            {
                pairs++;
                dc.Remove(word);
            }
            else
            {
                string sReve = StrReverse(word);
                if (dc.ContainsKey(sReve))
                {
                    pairs++;
                    dc.Remove(sReve);
                }
                else
                    dc.Add(word, 1);
            }
        return pairs;

    }

    public string StrReverse(string word)
    {
        char[] chAr = word.ToCharArray();
        Array.Reverse(chAr);
        return new string(chAr);
    }
}