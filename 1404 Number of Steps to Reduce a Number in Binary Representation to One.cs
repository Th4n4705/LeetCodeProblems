public class Solution {
    public int NumSteps(string s) {
        StringBuilder sb = new StringBuilder(s);
        int ans = 0;
        while (sb.Length > 1)
        {
            if (sb[sb.Length - 1] == '0')
                sb.Length--;
            else
            {
                int i = sb.Length - 1;
                while (i >= 0 && sb[i] == '1')
                {
                    sb[i] = '0';
                    i--;
                }
                if (i >= 0)
                    sb[i] = '1';
                else
                    sb.Insert(0, '1');
            }
            ans++;
        }
        return ans;
    }
}