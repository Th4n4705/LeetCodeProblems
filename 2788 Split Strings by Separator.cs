public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        IList<string> res = new List<string>();
        foreach (string word in words)
        {
            string[] sArray = word.Split(separator);
            for (int i = 0; i < sArray.Length; i++)
                if (sArray[i] != "")
                    res.Add(sArray[i]);
        }
        return res;
    }
}