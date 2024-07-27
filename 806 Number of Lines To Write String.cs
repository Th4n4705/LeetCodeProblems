public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int counter = 0;
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int ind = s[i] - 'a';
            sum += widths[ind];
            if (sum > 100)
            {
                counter++;
                sum = widths[ind];
            }
        }
        return new int[]{counter + 1, sum};
    }
}