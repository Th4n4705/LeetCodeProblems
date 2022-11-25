public class Solution {
    public bool CheckString(string s) {
        bool bAppears = false;
        for (int i = 0; i < s.Length; i++)
            if (s[i] == 'a' && bAppears)
                return false;
            else if (s[i] == 'b' && !bAppears)
                bAppears = true;
        return true;
    }
}