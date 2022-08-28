public class Solution {
    public bool IsPalindrome(string s) {
        
        string newS = SkipSpaces(s.ToLower());

        if (newS.Length == 0)
            return true;
        
        return IsStringPalandrom(newS);
    }
    
    public bool IsStringPalandrom(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        
        while(i < j)
        {
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
    
    public string SkipSpaces(string s)
    {
        int i = 0;
        List<char> newS = new List<char>();
        while (i < s.Length)
        {
            if ((s[i] >= 32 && s[i] <= 47) || (s[i] >= 58 && s[i] <= 64) || (s[i] >= 91 && s[i] <= 96) || (s[i] >= 123 && s[i] <= 126))
                i++;
            else
            {
                newS.Add(s[i]);
                i++;
            }
        }
        return new string(newS.ToArray());
    }
}