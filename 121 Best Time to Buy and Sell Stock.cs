public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell = 0;
        int profit = 0;
        int i = 0;
        
        if (prices.Length >= 1)
        {
            buy = prices[i];
            sell = prices[i];
        }
        
        while (i < prices.Length)
        {
            if (prices[i] > sell)
                sell = prices[i];
            else if (prices[i] < buy)
            {
                buy = prices[i];
                sell = prices[i];
            }
            if (profit < sell - buy)
                profit = sell - buy;
            
            i++;
        }
        
        return profit;
    }
}