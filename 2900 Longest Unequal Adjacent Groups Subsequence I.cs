public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<string> ans = new();
        int left = 0;
        int right = 1;
        while (right <= words.Length)
        {
            while (right < words.Length && groups[left] == groups[right])
                right++;
            ans.Add(words[left]);
            left = right;
            right = left + 1;
        }
        return ans;
    }
}