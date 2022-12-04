public class Solution {
    public bool IsCircularSentence(string sentence) {
        List<string> wordsList = sentence.Split(' ').ToList();
        if (sentence[0] != sentence[sentence.Length - 1])
            return false;
        for (int i = 0; i < wordsList.Count; i++)
        {
            if (i + 1 < wordsList.Count && wordsList[i][wordsList[i].Length - 1] != wordsList[i + 1][0])
                return false;
        }
        return true;
    }
}