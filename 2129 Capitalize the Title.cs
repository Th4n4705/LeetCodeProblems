public class Solution {
    public string CapitalizeTitle(string title) {
        var words = title.Split(new char[] {' '});
        int i = 1;
        string result = CapitalizeWord(words[0]);

        
        while (i < words.Length)
        {
            result = result + " " + CapitalizeWord(words[i]);
            
            i++;
        }
        
        return result;
    }
    
    public string CapitalizeWord(string word){
        int i = 0;
        char[] wordChar = word.ToCharArray();
        
        while (i < wordChar.Length)
        {
            if (i == 0 && word.Length > 2 && (wordChar[i] <= 'z' &&  wordChar[i] >= 'a'))
                wordChar[i] = (char)(wordChar[i] - 32);
            else if ((wordChar[i] <= 'Z' &&  wordChar[i] >= 'A') && (i != 0 || !(word.Length > 2)))
                wordChar[i] = (char)(wordChar[i] +  32);
            
            i++;
        }
        
        return new string(wordChar);
    }
}