public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        if (s.Length < p.Length)
            return new int[] {};
        int[] s1A = new int[26];
        int[] s2A = new int[26];
        List<int> result = new();
        for (int j = 0; j < p.Length; j++)
        {
            s1A[s[j] - 'a']++;
            s2A[p[j] - 'a']++;
        }
        if (CheckingArrays(s1A, s2A))
            result.Add(0);
        for (int i = p.Length; i < s.Length; i++)
        {
            s1A[s[i - p.Length] - 'a']--;
            s1A[s[i] - 'a']++;
            if (CheckingArrays(s1A, s2A))
                result.Add(i - p.Length + 1);
        }
        return result.ToArray();
    }

    public bool CheckingArrays(int[] ar1, int[] ar2)
    {
        int length = ar1.Length >= ar2.Length ? ar2.Length : ar1.Length;
        for (int i = 0; i < length; i++)
            if (ar1[i] != ar2[i])
                return false;
        return true;
    }
}