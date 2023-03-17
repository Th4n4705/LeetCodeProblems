public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length)
            return false;
        int[] s1A = new int[26];
        int[] s2A = new int[26];
        for (int k = 0; k < s1.Length; k++)
            s1A[s1[k] - 'a']++;
        int j = 0;
        int i = 0;
        while (i < s2.Length)
        {
            s2A[s2[i] - 'a']++;
            if (i - j + 1 == s1.Length && CheckingEquality(s1A, s2A))
                return true;
            if (i - j + 1 < s1.Length)
                i++;
            else
            {
                s2A[s2[j] - 'a']--;
                j++;
                i++;
            }
        }
        return false;
    }

    public bool CheckingEquality(int[] s1, int[] s2)
    {
        for (int i = 0; i < 26; i++)
            if (s1[i] != s2[i])
                return false;
        return true;
    }
}