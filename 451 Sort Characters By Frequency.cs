public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> dc = new();
        FrequencyCounter(dc, s);
        StringBuilder sb = new();
        List<char> ls = new List<char>(dc.Keys);
        ls.Sort((a, b) => dc[b].CompareTo(dc[a]));
        foreach (char c in ls)
        {
            int freq = dc[c];
            sb.Append(c, freq);
        }
        return sb.ToString();
    }

    private void FrequencyCounter(Dictionary<char, int> dc, string s)
    {
        for (int i = 0; i < s.Length; i++)
            if (dc.ContainsKey(s[i]))
                dc[s[i]]++;
            else
                dc.Add(s[i], 1);
    }
}