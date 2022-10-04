public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int i = 0;
        int counter = 0;
        
        while (i < tickets.Length)
        {
            if (tickets[i] != 0)
            {
                tickets[i]--;
                counter++;
            }
            
            if (i == k && tickets[k] == 0)
                break;
            i++;
            if (i >= tickets.Length && tickets[k] > 0)
                i = 0;
        }
        
        return counter;
    }
}