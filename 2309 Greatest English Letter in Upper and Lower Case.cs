public class Solution {
    public string GreatestLetter(string s) {
        bool upperCase = false;
        List<char> chs = new List<char>();
        chs.AddRange(s);
        chs.Sort();
        int i = chs.Count - 1;
        
        while (0 <= i)
        {
            if (chs[i] >= 'a' && chs[i] <= 'z')
                upperCase = false;
            else if (chs[i] >= 'A' && chs[i] <= 'Z')
                upperCase = true;

            int j = i - 1;
            while (0 <= j)
            {
                if (upperCase && chs[i] == (char)(chs[j] - 32))
                    return chs[i].ToString();
                else if (!upperCase && chs[i] == (char)(chs[j] + 32))
                    return chs[j].ToString();

                j--;
            } 
            i--;
        }
        return "";
    }
}