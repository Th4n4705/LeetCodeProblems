public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int largeWealth = 0;
        int wealth = 0;
        
        for (int i = 0; i < accounts.Length; i++)
        {
            wealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                wealth += accounts[i][j];
            }
            
            if (largeWealth < wealth)
                largeWealth = wealth;
        }
        
        return largeWealth;
    }
}