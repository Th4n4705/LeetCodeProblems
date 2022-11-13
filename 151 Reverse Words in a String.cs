public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        string[] sList = s.Split(" ");
        string newS = "";
        for (int i = sList.Length - 1; i >= 0; i--)
            newS += sList[i] + " ";
        while(newS.Contains("  "))
            newS = newS.Replace("  ", " ");

        return newS.Trim();
    }
}