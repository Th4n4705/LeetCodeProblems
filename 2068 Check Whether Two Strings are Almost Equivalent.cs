public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        int[] wordsDiff = new int[26];
        for (int i = 0; i < word1.Length; i++)
        {
            wordsDiff[word1[i] - 97]++;
            wordsDiff[word2[i] - 97]--;
        }
        return wordsDiff.Min() >= -3 && wordsDiff.Max() <= 3;
    }
}