public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        int[] AlphaMap = new int[26];
        for (int i = 0; i < order.Length; i++)
        {
            AlphaMap[order[i] - 'a'] = i;
        }
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (i + 1 < words.Length)
                {
                    if (j >= words[i + 1].Length)
                        return false;
                    if (words[i][j] != words[i + 1][j])
                    {
                        if (AlphaMap[words[i][j] - 'a'] > AlphaMap[words[i + 1][j] - 'a'])
                            return false;
                        else
                            break ;
                    }
                }
            }
        }
        return true;
    }
}