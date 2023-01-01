public class Solution {
    public bool WordPattern(string pattern, string s) {
        List<string> sList = s.Split(' ').ToList();

        if (pattern.Length != sList.Count)
            return false;

        Dictionary<char,string> dc = new();

        for (int i = 0; i < pattern.Length; i++)
            if(!dc.ContainsKey(pattern[i]))
                dc.Add(pattern[i], sList[i]);
        
        if (!DictionarryCheck(dc))
            return false;

        for (int i = 0; i < pattern.Length; i++)
            if (dc[pattern[i]] != sList[i])
                return false;
        return true;
    }

    public bool DictionarryCheck(Dictionary<char,string> dc)
    {
        for (int i = 0; i < dc.Count; i++)
        {
            for (int j = i + 1; j < dc.Count; j++)
                if (dc.ElementAt(i).Value == dc.ElementAt(j).Value)
                    return false;
        }
        return true;
    }
}