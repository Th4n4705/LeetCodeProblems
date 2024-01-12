public class Solution {
    public string ReverseOnlyLetters(string s) {
        StringBuilder sb = new();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            while (sb.Length < s.Length && !IsLetter(s[sb.Length]))
                sb.Append(s[sb.Length]);
            if (IsLetter(s[i]))
                sb.Append(s[i]);
            while (sb.Length < s.Length && !IsLetter(s[sb.Length]))
                sb.Append(s[sb.Length]);
        }
        return sb.ToString();
    }

    private bool IsLetter(in char ch)
    {
        return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
    }
}