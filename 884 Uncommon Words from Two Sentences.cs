public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        string[] s1Array = s1.Split(' ');
        string[] s2Array = s2.Split(' ');
        List<string> allWords = new List<string>();
        List<string> resultList = new List<string>();
        
        FillList(allWords, s1Array);
        FillList(allWords, s2Array);
        
        UncommonHelper(allWords, resultList);
        
        return resultList.ToArray();
    }
    
    public void FillList(List<string> result, string[] s1Array)
    {
        for (int i = 0; i < s1Array.Length; i++)
        {
            result.Add(s1Array[i]);
        }
    }
    
    
    public void UncommonHelper(List<string> allWords, List<string> result)
    {        
        bool found = false;
        
        for (int i = 0; i < allWords.Count; i++)
        {
            found = false;

            for (int j = 0; j < allWords.Count; j++)
            {
                if (allWords[i] == allWords[j] && i != j)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                result.Add(allWords[i]);
        }
    }
}