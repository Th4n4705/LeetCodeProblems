public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder sb = new();
        for(int i = 0; i < word1.Length; i++)
        {
            sb.Append(word1[i]);
        }
        string word1str = sb.ToString();
        sb = new();
        for(int i = 0; i < word2.Length; i++)
        {
            sb.Append(word2[i]);
        }
        string word2str = sb.ToString();
        return word1str == word2str ? true : false;
    }
}