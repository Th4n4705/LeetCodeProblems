public class Solution {
    public string FinalString(string s) {
        StringBuilder sb = new();
        foreach (char c in s)
            if (c == 'i')
                sb = Reverse(sb.ToString());
            else
                sb.Append(c);
        return sb.ToString();
    }

    private StringBuilder Reverse (string text)
    {
        StringBuilder sb = new();
        for (int i = text.Length - 1; i >= 0; i--)
            sb.Append(text[i]);
        return sb;
    }
}