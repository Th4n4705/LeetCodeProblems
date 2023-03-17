public class Solution {
    public int[] FinalPrices(int[] prices) {
        List<int> pricesList = new();
        for (int i = 0; i < prices.Length; i++)
        {
            int min = 0;
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[i] >= prices[j])
                {
                    min = prices[j];
                    break;
                }
            }
            if (min != 0)
                pricesList.Add(prices[i] - min);
            else
                pricesList.Add(prices[i]);
        }
        return pricesList.ToArray();
    }
}