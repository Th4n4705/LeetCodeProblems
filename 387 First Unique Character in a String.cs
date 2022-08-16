public class Solution {
    public int FirstUniqChar(string s)
    {
        if (s.Length == 1)
            return 0;
        
        int founded;
        for (int i = 0; i < s.Length; i++)
        {
            founded = 0;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                            founded++;
                        
                        if (founded > 1)
                            break;
                    }
            if (founded == 1)
                return i;
        }
        return -1;
    }
}