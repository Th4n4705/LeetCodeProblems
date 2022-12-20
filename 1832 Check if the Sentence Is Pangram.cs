public class Solution {
    public bool CheckIfPangram(string sentence) {
        Dictionary<char, int> dc = new();
        for (int i = 0; i < sentence.Length; i++)
        {
            if (dc.ContainsKey(sentence[i]))
                dc[sentence[i]]++;
            else
                dc.Add(sentence[i], 0);
        }
        return dc.Count == 26? true: false;
    }
}