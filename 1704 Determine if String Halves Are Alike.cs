public class Solution {
    public bool HalvesAreAlike(string s) {
        HashSet<char> vowelHashSet = new(){'a','e','i','o','u','A','E','I','O','U'};
        int counter = 0;
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            if (vowelHashSet.Contains(s[i]))
                counter++;
            if (vowelHashSet.Contains(s[j]))
                counter--;
            i++;
            j--;
        }
        if (counter == 0)
            return true;
        return false;
    }
}

/*public class Solution {
    public bool HalvesAreAlike(string s) {
        string a;
        string b;
        SplitIt(s, out a, out b);
        int aCount = 0;
        int bCount = 0;
        VowelCheck(a, out aCount);
        VowelCheck(b, out bCount);
        if (aCount == bCount)
            return true;
        return false;
    }
    
    public void SplitIt(string s, out string a, out string b)
    {
        a = String.Empty;
        b = String.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length / 2)
                a += s[i];
            else
                b += s[i];
        }
    }
    
    
    public void VowelCheck(string a, out int b)
    {
        List<char> vowelList = new(){'a','e','i','o','u','A','E','I','O','U'};
        b = 0;
        for (int i = 0; i < a.Length; i++)
        {
            foreach (var vowel in vowelList)
                if (a[i] == vowel)
                {
                    b++;
                    break ;
                }
        }
    }
}*/