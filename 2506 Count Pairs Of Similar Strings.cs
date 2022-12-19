public class Solution {
    public int SimilarPairs(string[] words) {
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (SimPairs(words[i], words[j]))
                    counter++;
            }
        }
        return counter;
    }

    public bool SimPairs(string word1, string word2)
    {
        List<char> wL1 = word1.ToList();
        List<char> wL2 = word2.ToList();
        int LengthMax = (word2.Length <= word1.Length ? word1.Length : word2.Length);
        for (int i = 0; i < LengthMax; i++)
        {
            if ((i < word2.Length && wL1.IndexOf(word2[i]) == -1) || (i < word1.Length && wL2.IndexOf(word1[i]) == -1))
                return false;
        }
        return true;
    }
}