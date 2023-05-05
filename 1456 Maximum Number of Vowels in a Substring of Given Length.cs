public class Solution {
    public int MaxVowels(string s, int k) {
        int ans = 0;
        int counter = 0;
        for (int i = 0; i < k; i++)
            if (IsVowel(s[i]))
                counter++;
        ans = counter;
        for (int i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i - k]))
                counter--;
            if (IsVowel(s[i]))
                counter++;
            ans = Math.Max(ans, counter);
        }
        return ans;
    }

    public bool IsVowel(char ch)
    {
        return (ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u');
    }
}