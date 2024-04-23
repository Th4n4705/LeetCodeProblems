public class Solution {
    public int NumberOfSpecialChars(string word) {
        int ans = 0;
        int[] counter = new int[26];
        int[] counter2 = new int[26];
        for (int i = 0; i < word.Length; i++)
        {
            int n = word[i];
            if (n >= 'a' && n <= 'z')
                counter[n - 'a']++;
            else
                counter2[n - 'A']++;
        }
        for (int i = 0; i < 26; i++)
            if (counter[i] > 0 && counter2[i] > 0)
                ans++;
        return ans;
    }
}