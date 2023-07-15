public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        string[] s = text.Split(" ");
        int counter = 0;
        foreach (string ss in s)
        {
            bool found = false;
            foreach (char c in brokenLetters)
                if (ss.Contains(c))
                {
                    found = true;
                    break ;
                }
            if (!found)
                counter++;
        }
        return counter;
    }
}