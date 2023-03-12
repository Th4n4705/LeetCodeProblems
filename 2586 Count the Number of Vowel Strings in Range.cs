public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        string vowels = "aeiou";
        int counter = 0;
        for (int i = left; i <= right; i++)
        {
            int length = words[i].Length - 1;
            if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][length]))
                counter++;
        }
        return counter;
    }
}