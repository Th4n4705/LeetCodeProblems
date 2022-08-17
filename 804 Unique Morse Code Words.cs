public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        List<string> morseWords = new List<string>();
        
        foreach (string word in words)
        {
            string currentWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                currentWord += CryptedChar(word[i]);
            }
            if (!isMorseFounded(currentWord,morseWords))
                morseWords.Add(currentWord);
        }
        return morseWords.Count;
    }
    
    public string CryptedChar(char ch)
    {
        string[] arr = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        return arr[(int)ch - 97];
    }
    
    public bool isMorseFounded (string s, List<string> cryptWords)
    {
        if (cryptWords.Count == 0)
            return false;
        
        foreach (string word in cryptWords)
            if (word == s)
                return true;
        return false;
    }
}