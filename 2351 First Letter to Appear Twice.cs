public class Solution {
    public char RepeatedCharacter(string s) {
        List<char> sListIn = new List<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (sListIn.IndexOf(s[i]) == -1)
                sListIn.Add(s[i]);
            else
                return s[i];
        }
        
        return s[0];
    }
}