public class Solution {
    public bool ReportSpam(string[] message, string[] bannedWords) {
        int counter = 0;
        HashSet<string> hs = new HashSet<string>(bannedWords);
        foreach (string s in message)
            if (hs.Contains(s))
            {
                counter++;
                if (counter > 1)
                    return true;
            }
        return false;
    }
}