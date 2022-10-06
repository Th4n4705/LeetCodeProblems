public class Solution {
    public bool AreNumbersAscending(string s) {
        List<string> words = new List<string>();
        words = s.Split(' ').ToList();
        int i = 0;
        int? lastInteger = null;
        int newInteger;
        
        while (i < words.Count)
        {
            if (int.TryParse(words[i], out newInteger))
            {
                if (lastInteger == null || lastInteger < newInteger)
                    lastInteger = newInteger;
                else
                    return false;
            }
            
            i++;
        }
        
        return true;
    }
}