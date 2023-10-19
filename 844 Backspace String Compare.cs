public class Solution {
    public bool BackspaceCompare(string s, string t) {
        char[] chS = s.ToCharArray();
        char[] chT = t.ToCharArray();
        int T = StringHelper(chT);
        int S = StringHelper(chS);
        if (S != T)
            return false;
        for (int i = 0; i < T; i++)
            if (chT[i] != chS[i])
                return false;
        return true;
    }

    private int StringHelper (char[] ch)
    {
        int counter = 0;
        foreach (char c in ch)
            if (c != '#')
                ch[counter++] = c;
            else if (counter > 0)
                counter--;
        return counter;
    }
}