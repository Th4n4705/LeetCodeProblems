public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        string newS = "";
        
        for (int i = 0; i < words.Length; i++)
        {
            newS += words[i];
            if (newS == s)
                return true; 
        }
        return false;
    }
}