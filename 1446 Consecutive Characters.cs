public class Solution {
    public int MaxPower(string s) {
        int max = 1;
        for (int i = 0; i < s.Length; i++)
        {
            int counter = 0;
            if (i + 1 < s.Length && s[i] == s[i + 1])
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        counter++;
                    else
                        break;
                }
                if (max < counter)
                    max = counter;
            }
        }
        return max == 0 ? 1 : max;
    }
}