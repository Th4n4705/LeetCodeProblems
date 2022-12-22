public class Solution {
    public int SecondHighest(string s) {
        int max = -1;
        int secondMax = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (Int32.TryParse(s[i].ToString(), out int k))
            {
                if (k > max)
                {
                    secondMax = max;
                    max = k;
                }
                else if (k > secondMax && k < max)
                    secondMax = k;
            }
        }
        return secondMax;
    }
}