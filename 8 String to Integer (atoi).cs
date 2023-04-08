public class Solution {
    public int MyAtoi(string s) {
        long ans = 0;
        int sign = 1;
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
            return 0;
        int index = 0;
        if (s[0] == '+' || s[0] =='-')
        {
            sign = s[0] == '+' ? 1 : -1;
            index++;
        }
        while (index < s.Length)
        {
            if (char.IsNumber(s[index]))
            {
                ans = ans * 10 + s[index] - '0';
                if (ans * sign > int.MaxValue)
                    return int.MaxValue;
                if (ans * sign < int.MinValue)
                    return int.MinValue;
            }
            else
                break;
            index++;
        }
        return (int)ans * sign;
    }
}