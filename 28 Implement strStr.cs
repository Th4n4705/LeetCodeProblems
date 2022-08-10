public class Solution {
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0)
            return 0;
        int i = 0;
        int treatedI;
        int j;
        int correctChar = 0;
        while (haystack.Length > i)
        {
            j = 0;
            if (haystack[i] == needle[j])
            {
                if (haystack.Length - i - needle.Length < 0)
                    return -1;
                treatedI = i;
                correctChar = 0;
                while (needle.Length > j)
                {
                    if (haystack[treatedI] == needle[j])
                        correctChar++;
                    treatedI++;
                    j++;
                }
                if (correctChar == needle.Length)
                    return i;
            }
            i++;
        }
        return -1;
    }
}