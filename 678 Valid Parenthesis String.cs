public class Solution {
    public bool CheckValidString(string s) {
        int counter = 0;
        foreach (char c in s)
        {
            if (c == '(' || c == '*')
                counter++;
            else if (c == ')')
                counter--;
            if (counter < 0)
                return false;
        }
        counter = 0;
        for (int i = s.Length - 1; 0 <= i; i--)
        {
            if (s[i] == ')' || s[i] == '*')
                counter++;
            else
                counter--;
            if (counter < 0)
                return false;
        }
        return true;
    }
}