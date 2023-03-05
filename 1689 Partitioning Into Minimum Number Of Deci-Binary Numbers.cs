public class Solution {
    public int MinPartitions(string n) {
        int max = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] - '0' == 9) 
                return 9;
            max = Math.Max(max, (n[i] - '0'));
        }
        return max;
    }
}