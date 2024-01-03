public class Solution {
    public bool LemonadeChange(int[] bills) {
        int five = 0;
        int ten = 0;
        for (int i = 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                five++;
                continue;
            }
            if (bills[i] == 10)
            {
                if (five == 0)
                    return false;
                ten++;
                five--;
                continue;
            }
            if (ten > 0)
            {
                if (five == 0)
                    return false;
                ten--;
                five--;
            }
            else
            {
                if (five >= 3)
                {
                    five -= 3;
                    continue;
                }
                return false;
            }
        }
        return true;
    }
}