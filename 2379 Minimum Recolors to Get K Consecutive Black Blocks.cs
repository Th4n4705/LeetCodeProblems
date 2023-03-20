public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int min = Int32.MaxValue;
        int counter = 0;
        int beginning = 0;
        for (int i = 0; i < blocks.Length; i++)
        {
            if (blocks[i] == 'W')
                counter++;
            if (i - beginning + 1 == k)
            {
                min = Math.Min(min, counter);
                if (blocks[beginning++] == 'W')
                    counter--;
            }
        }
        return min;
    }
}