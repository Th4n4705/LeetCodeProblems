public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices);
        for (int i = 0; i <prices.Length; i++)
            if (i + 1 < prices.Length && prices[i] + prices[i + 1] <= money)
                return money - (prices[i] + prices[i + 1]);
        return money;
    }
}