public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int counter = 0;
        StringBuilder sb = new();
        foreach (char c in s)
        {
            if (c == '(')
                counter++;
            else if (c == ')')
            {
                if (counter == 0)
                    continue;
                counter--;
            }
            sb.Append(c);
        }
        StringBuilder ans = new();
        for (int i = sb.Length - 1; 0 <= i; i--)
        {
            if (sb[i] == '(' && counter > 0)
            {
                counter--;
                continue;
            }
            ans.Insert(0, sb[i]);
        }
        return ans.ToString();
    }
}