public class Solution {
    public int SplitNum(int num) {
        string s = String.Concat(num.ToString().OrderBy(ch => ch));
        string n1 = string.Empty;
        string n2 = string.Empty;
        for (int i = 0; i < s.Length; i += 2)
        {
            n1 += s[i];
            if (i + 1 < s.Length)
                n2 += s[i + 1];
        }
        return Int32.Parse(n1) + Int32.Parse(n2);
    }
}