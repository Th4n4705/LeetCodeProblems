public class Solution {
    public string RemoveDuplicates(string s) {
        return  RemovableDuplication(s,true);
    }
    
    public string RemovableDuplication(string s, bool is_AdjaDup)
    {
        if  (!is_AdjaDup)
            return  s;

        bool is_DuplicationFound = false;
        int  nextI = -5;
        for(int i = 0; i < s.Length; i++)
        {
            if(i + 1 < s.Length && s[i] == s[i + 1] && nextI == -5)
            {
                is_DuplicationFound = true;
                s = s.Remove(i, 2);
                break;
            }
        }
        if (!is_DuplicationFound)
            return  RemovableDuplication(s,false);
        return  RemovableDuplication(s,true);
    }
}