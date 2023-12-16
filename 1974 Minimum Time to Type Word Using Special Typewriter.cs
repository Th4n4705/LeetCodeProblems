public class Solution {
    public int MinTimeToType(string word) {
        int ans = 0;
        word = word.Insert(0, "a");
        for (int i = 0; i < word.Length - 1; i++)
            if (Math.Abs((int)word[i] - (int)word[i + 1]) > 13)
                ans += (26 - Math.Abs((int)word[i] - (int)word[i + 1]));
            else
                ans += Math.Abs((int)word[i] - (int)word[i + 1]);
        return ans + (word.Length - 1);
    }
}