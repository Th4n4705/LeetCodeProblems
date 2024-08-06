public class Solution {
    public int MinimumPushes(string word) {
        int[] arr = new int[26];
        for (int i = 0; i < 26; i++)
            arr[i] = 0;
        for (int i = 0; i < word.Length; i++)
            arr[(int)word[i] - 97]++;
        Array.Sort(arr);
        int n = 0;
        for (int i = 25; i >= 0; i--)
            n += arr[i] * ((int)((25 - i) / 8) + 1);
        return n;
    }
}