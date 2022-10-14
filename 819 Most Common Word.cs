public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        string moreCommon = "";
        int counterCommon = 0;
        int counter = 1;
        List<string> wordsList = new List<string>();
        paragraph = paragraph.ToLower();
        wordsList =  paragraph.Split(' ',',',';','.','!','?','\'').ToList();
        if (banned.Length > 0)
            RemoveBannedWords(wordsList, banned);
        
        for (int i = 0; i < wordsList.Count; i++)
        {
            if (wordsList[i] != moreCommon)
            {
                counter = 1;
                for (int j = i + 1; j < wordsList.Count; j++)
                {
                    if (wordsList[i] == wordsList[j])
                        counter++;
                }
                
                if (counter > counterCommon)
                {
                    counterCommon = counter;
                    moreCommon = wordsList[i];
                }
            }
        }
        return moreCommon;
    }
    
    public void RemoveBannedWords(List<string> wordsList, string[] banned)
    {
        for (int i = 0; i < wordsList.Count; i++)
        {
            for (int j = 0; j < banned.Length; j++)
            {
                if (wordsList[i] == banned[j])
                {
                    wordsList[i] = "";
                    break;
                }
            }
        }
        
        for (int j = wordsList.Count - 1; j >= 0; j--)
        {
            if (wordsList[j] == "")
                wordsList.RemoveAt(j);
        }

    }
}