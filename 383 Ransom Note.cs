public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int repeatedRansomLetter = 0;
        int i = 0;
        char currentChar;
        
        while (i < ransomNote.Length)
        {
            if (ransomNote[i] == ' ')
                i++;
            currentChar = ransomNote[i];
            repeatedRansomLetter = LetterFounder (ransomNote, currentChar);

            if (repeatedRansomLetter > LetterFounder (magazine, currentChar))
                return false;
            i++;
        }
        return true;
    }
    
    public int LetterFounder (string str, char ch)
    {
        int i = 0;
        int counter = 0;
        
        while (i < str.Length)
        {
            if (str[i] == ch)
                counter++;
            i++;
        }
        
        return counter;
    }
}