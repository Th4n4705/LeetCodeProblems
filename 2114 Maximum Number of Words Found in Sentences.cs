public class Solution {
    public int MostWordsFound(string[] sentences) {
        int i = 0;
        int counter = 0;
        
        while (i < sentences.Length)
        {
            string[] words = sentences[i].Split(" ");
            if (counter < words.Length)
                counter = words.Length;
            i++;
        }
        
        return counter;
    }
}