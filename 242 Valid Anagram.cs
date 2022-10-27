public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char>  sList = new List<char>();
        List<char> tList = new List<char>();
        sList = s.ToList();
        tList = t.ToList();
        
        sList.Sort();
        tList.Sort();

        if  (tList.Count != sList.Count)
            return false;
        for (int i = 0; i < tList.Count; i++)
        {
            if (tList[i] !=  sList[i])
                return  false;
        }
        
        return true;
    }
}