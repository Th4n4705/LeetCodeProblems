public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        if (costs[0] > coins)
            return 0;
        int counter = 0;
        for (int i = 0; i < costs.Length; i++)
        {
            if (costs[i] <= coins)
            {
                counter++;
                coins -= costs[i];
            }
            else
                break;
        }
        return counter;
    }
}