public class Solution {
    public int PercentageLetter(string s, char letter)
    {
        float result =  ((float)letterCounter(s, letter) / s.Length) * 100;
        float rest = result - (int)result;
        
        
        if (rest < 1 && rest > 0.97)
            return  (int)result + 1;
        return  (int)result;
    }
    
    public int letterCounter(string s, char letter)
    {
        int i = 0;
        int counter = 0;
        while (i < s.Length)
        {
            if (s[i] == letter)
                counter++;
            i++;
        }
        
        return counter;
    }
}