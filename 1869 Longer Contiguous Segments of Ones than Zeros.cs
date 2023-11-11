public class Solution {
    public bool CheckZeroOnes(string s) {
        int one = 0;
        int zero = 0;
        int tmp = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                while (i < s.Length && s[i] == '0')
                {
                    i++;
                    tmp++;
                }
                zero = Math.Max(zero, tmp);
                tmp = 0;
                i--;
            }
            else
            {
                while (i < s.Length && s[i] == '1')
                {
                    i++;
                    tmp++;
                }
                one = Math.Max(one, tmp);
                tmp = 0;
                i--;
            }
        }
        return zero < one;
    }
}