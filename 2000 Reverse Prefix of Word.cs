public class Solution {
    public string ReversePrefix(string word, char ch) {
        string result = word;
        if (word.Contains(ch))
        {
            result = "";
            List<char> chList = new List<char>();
            chList = word.ToList();
            for (int i = chList.IndexOf(ch); i >= 0; i--)
                result += chList[i];
            for (int j = chList.IndexOf(ch) + 1; j < chList.Count; j++)
                result += chList[j];
        }
        
        return result;
    }
}