public class Solution {
    public int NumDifferentIntegers(string word) {
        HashSet<string> hs = new();
        for (int i = 0; i < word.Length; i++)
            if (Char.IsDigit(word[i]))
            {
                StringBuilder sb = new();
                while (i < word.Length && Char.IsDigit(word[i]))
                {
                    sb.Append(word[i]);
                    i++;
                }
                hs.Add(sb.ToString().TrimStart('0'));
            }
        return hs.Count;
    }
}