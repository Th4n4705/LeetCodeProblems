public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int counter = s.Count(n => n == '1');
        StringBuilder sb = new StringBuilder(s.Length);
        sb.Append('1', counter - 1).Append('0', s.Length - counter)
        .Append('1');
        return sb.ToString();
    }
}