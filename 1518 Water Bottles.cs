public class Solution {
    int res = 0;
    public int NumWaterBottles(int numBottles, int numExchange) {
        //exceptions        
        if (numBottles == 0 && res < numExchange)
            return 0;
        if (numBottles < numExchange)
        {
            numBottles += (res / numExchange);
            res = res % numExchange;
        }
        else if (numBottles < numExchange)
            return numBottles;
        
        res += numBottles % numExchange;
        return numBottles + NumWaterBottles(((numBottles) / numExchange) , numExchange);
    }
}