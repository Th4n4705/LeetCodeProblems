
public class Solution {
    public int CountAsterisks(string s) {
        List<char> asterL = new();
        int counter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
            {
                if (asterL.Count == 0)
                    asterL.Add('|');
                else
                    asterL.Remove('|');
            }
            if (s[i] == '*' && asterL.Count == 0)
                counter++;
        }
        return counter;
    }
}