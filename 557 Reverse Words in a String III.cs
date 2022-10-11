public class Solution {
    public string ReverseWords(string s) {
        List<string> sList = new List<string>();
        sList = s.Split(" ").ToList();
        int i = 0;
        string result = "";
        
        while (i < sList.Count)
        {
            result += ReverseIt(sList[i]);
            if (i + 1 < sList.Count)
                result += " ";
            i++;
        }
        
        return result;
    }
    
    public string ReverseIt(string word)
    {
        string ReversedWord = "";
        int i = word.Length - 1;
        
        while (i >= 0)
        {
            ReversedWord += word[i].ToString();
            i--;
        }
        return ReversedWord;
    }
}