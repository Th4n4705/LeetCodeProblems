public class Solution {
    public string ToGoatLatin(string sentence) {
        string[] words = sentence.Split(" ");
        StringBuilder sb = new();
        for (int i = 0; i < words.Length; i++)
        {
            if (VowelStart(words[i]))
                sb.Append(words[i]).Append("ma");
            else
                sb.Append(words[i].Substring(1)).Append(words[i].Substring(0, 1)).Append("ma");
            for (int j = 0; j <= i; j++)
                sb.Append('a');
            sb.Append(" ");
        }
        return sb.ToString().Trim();
    }

    private bool VowelStart(string word)
    {
        if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
            return true;
        return false;
    }
}