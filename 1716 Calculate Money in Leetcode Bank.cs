public class Solution {
    public int TotalMoney(int n) {
        int counter = 0;
        int week = 0;
        int dayRate = 1;
        for (int i = 1; i <= n; i++)
        {
            counter += dayRate++ + week;
            if (i % 7 == 0)
            {
                week++;
                dayRate = 1;
            }
        }
        return counter;
    }
}