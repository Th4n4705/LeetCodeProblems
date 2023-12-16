public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int sumLen = 0;
        int[] frequency = new int[26];
        for (int i = 0; i < chars.Length; i++)
            frequency[chars[i] - 'a']++;
        foreach (string word in words)
        {
            int[] freqWord = new int[26];
            sumLen += word.Length;
            for (int i = 0; i < word.Length; i++)
            {
                int index = word[i] - 'a';
                freqWord[index]++;
                if (freqWord[index] > frequency[index])
                {
                    sumLen -= word.Length;
                    break;
                }
            }
        }
        return sumLen;
    }
}