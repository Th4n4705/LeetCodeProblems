public class Solution {
    public bool CheckOnesSegment(string s) {
        bool alreadyFound = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!alreadyFound && s[i] == '1')
                alreadyFound = true;
            else if (i - 1 >= 0  && alreadyFound && s[i] == '1' && s[i - 1] == '0')
                return false;
        }
        return true;
    }
}