public class Solution {
    public string ClearDigits(string s) {
        StringBuilder sb = new();
        foreach (char c in s)
            if (!char.IsDigit(c))
                sb.Append(c);
            else
                sb.Length--;
        return sb.ToString();
    }
}