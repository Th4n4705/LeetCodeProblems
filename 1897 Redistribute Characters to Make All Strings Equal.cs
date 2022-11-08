public class Solution {
    public bool MakeEqual(string[] words) {
        string  allWords = "";
        foreach (var word in words)
            allWords += word;
        
        for (int ch = 97; ch <= 122; ch++)
        {
            int counter = 0;            
            for (int i = 0; i < allWords.Length; i++)
                if (allWords[i] == (char)ch)
                    counter++;
            if (counter != 0 && counter % words.Length != 0)
                return  false;
        }
        
        return true;
    }
}