public class Solution {
    public int DivisorSubstrings(int num, int k) {
        int counter = 0;
        int i = 0;
        string s = num.ToString();
        
        while (i < s.Length)
        {
            string newS = "";
            int digits = 0;
            if (i + k <= s.Length)
            {
                digits = FillTheNum(s, k, i);
                
                if (digits != 0 && num % digits == 0)
                    counter++;
            }
            
            i++;
        }
        
        return counter;
    }
    
    public int FillTheNum(string s, int k, int index)
    {
        int i = index;
        string newS = "";
        int  digits = 0;
        
        while (i < s.Length && (i + 1) - index <= k)
        {    
            newS += s[i];
            i++;
        }
        
        Int32.TryParse(newS,out digits);

        return digits;
    }
}