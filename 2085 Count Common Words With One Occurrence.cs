public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        int result = 0;
        foreach (var word in words1)
        {
            if (checker(word, words1, words2) == 2)
                result++;
        }
        
        return result;
    }
    
    public int checker(string s, string[] sArray1, string[] sArray2)
    {
        int counter = 0;
        foreach (var word in sArray1)
            if (s == word)
                counter++;
            else if (counter > 1)
                return 101;
        
        foreach (var word in sArray2)
            if (s == word)
                counter++;
            else if (counter > 2)
                return 101;
        return counter;
    }
}