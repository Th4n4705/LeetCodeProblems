public class Solution {
    public string TruncateSentence(string s, int k) {
       List<string> sList = s.Split(" ").ToList();
       StringBuilder sb = new();
       sb.Append(sList[0]);
       for (int i = 1; i < k; i++)
       {
           sb.Append(" " + sList[i]);
       }
       return sb.ToString();
    }
}