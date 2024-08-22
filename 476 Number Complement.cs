public class Solution {
    public int FindComplement(int num) {
        if (num == 0)
            return 1;
        StringBuilder sb = new();
        string s = Convert.ToString(num, 2);
        foreach(char c in s)
            sb.Append(c == '0' ? '1' : '0');
        return Convert.ToInt32(sb.ToString(), 2);
    }
}