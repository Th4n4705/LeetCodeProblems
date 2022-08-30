public class Solution {
    public int HammingWeight(uint n) {
        string fullN = Convert.ToString(n, 2);
        int count = 0;
        
        for (int i = 0; i < fullN.Length; i++)
            if (fullN[i] == '1')
                count++;
        
        return count;
    }
}