public class Solution {
    public bool CheckRecord(string s) {
        int absent = 0;
        int i = 0;
        
        while (i < s.Length)
        {
            if (s[i] == 'A')
            {
                absent++;
            }
            else if (i >= 2 && s[i] == 'L' && s[i - 1] == 'L' && s[i - 2] == 'L')
                return false;
            
            if (absent >= 2)
                return false;
            i++;
        }
        
        return true;
    }
}