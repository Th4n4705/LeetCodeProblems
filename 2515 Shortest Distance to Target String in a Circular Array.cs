public class Solution {
    public int ClosetTarget(string[] words, string target, int startIndex) {
        int ans = int.MaxValue;
        for (int i = 0; i < words.Length; i++)
            if (words[i] == target)
            {
                int abs = Math.Abs(i - startIndex);
                ans = Math.Min(ans, Math.Min(abs, words.Length - abs));
            }
        return ans != int.MaxValue? ans : -1;
    }
}