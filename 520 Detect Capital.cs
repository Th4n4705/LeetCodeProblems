public class Solution {
    public bool DetectCapitalUse(string word) {
        string clone = ChangeIt(word);
        if(word.ToUpper() == word || word.ToLower() == word || clone == word)
            return true;
        return false;
    }

    public string ChangeIt(string word)
    {
        StringBuilder sb = new();
        word = word.ToLower();
        for (int i = 0; i < word.Length; i++)
        {
            if (i == 0)
                sb.Append((char)(word[i] - 32));
            else
                sb.Append(word[i]);
        }
        return sb.ToString();
    }
}