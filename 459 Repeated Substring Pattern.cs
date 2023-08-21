public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int j = 1;
        while (j < s.Length)
        {
            string sb = s.Substring(0, j);
            if (s.Length % j == 0)
            {
                bool ans = true;
                for (int i = j; i < s.Length; i += j)
                    if (s.Substring(i, j) == sb)
                        continue;
                    else
                    {
                        ans = false;
                        break;
                    }
                if (ans)
                    return ans;
            }
            j++;
        }
        return false;
    }
}