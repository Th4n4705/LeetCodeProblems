public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        return (WordSum(firstWord) + WordSum(secondWord)) == WordSum(targetWord);
    }

    public int WordSum(string word)
    {
        StringBuilder sumStr = new();
        for (int i = 0; i < word.Length; i++)
        {
            sumStr.Append(word[i] - 'a');
        }
        return Convert.ToInt32(sumStr.ToString());
    }
}