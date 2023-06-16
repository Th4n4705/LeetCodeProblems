public class Solution {
    public string ModifyString(string s) {
        char[] ch = s.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
            if (ch[i] == '?')
                for (char c = 'a'; c < 'd'; c++)
                    if ((i == 0 || ch[i - 1] != c) && (i == ch.Length - 1 || ch[i + 1] != c))
                    {
                        ch[i] = c;
                        break;
                    }
        return new String(ch);
    }
}