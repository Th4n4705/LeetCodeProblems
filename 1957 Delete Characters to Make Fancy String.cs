public class Solution {
    public string MakeFancyString(string s) {
        int counter = 1;
        StringBuilder result = new StringBuilder();
        result.Append(s[0]);
        
        for (int i = 1; i < s.Length; i++)
        {
            counter = (result[result.Length - 1] == s[i]) ? counter + 1 : 1;

            if (counter < 3)
                result.Append(s[i]);
        }
        
        return result.ToString();
    }
}