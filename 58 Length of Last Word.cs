public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int counter = 0;
        
        while (i >= 0)
        {
            if (s[i] != ' ')
                break;
            i--;
        }
        
        while (i >= 0 && s[i] != ' ')
        {
            counter++;
            i--;
        }
        
        return counter;
    }
}