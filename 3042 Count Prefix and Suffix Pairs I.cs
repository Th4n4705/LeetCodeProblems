public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int ans = 0;
        for (int i = 0; i < words.Length - 1; i++)
            for (int j = i + 1; j < words.Length; j++)
                if (IsPrefixSuffix(words[i], words[j]))
                    ans++;
        return ans;
    }

    private bool IsPrefixSuffix(string s0, string s1)
    {
        if (!s1.StartsWith(s0))
            return false;
        return s1.EndsWith(s0);
    }
}