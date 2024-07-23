public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        string ans = string.Empty;
        int[] arr = CharCounter(licensePlate);

        foreach (string s in words)
        {
            bool isPair = true;
            int[] wordAr = CharCounter(s);
            for (int i = 0; i < 26 && isPair; i++)
                isPair &= wordAr[i] >= arr[i];
            if (isPair && (ans == string.Empty || s.Length < ans.Length))
                ans = s;
        }
        return ans;
    }

    int[] CharCounter(string s)
    {
        int[] arr = new int[26];
        foreach (char c in s)
            if (char.IsLetter(c))
                arr[char.ToLower(c) - 'a']++;
        return arr;
    }
}