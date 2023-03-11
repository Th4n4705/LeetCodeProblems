public class Solution {
    public IList<string> CommonChars(string[] words) {
        List<string> first = words[0].ToCharArray().Select(c => c.ToString()).ToList();
        foreach (var word in words)
        {
            List<string> charCheck = new();
            foreach (var charR in word)
                if (first.Contains(charR.ToString()))
                {
                    charCheck.Add(charR.ToString());
                    first.Remove(charR.ToString());
                }
            first = new(charCheck);            
        }
        return first;
    }
}