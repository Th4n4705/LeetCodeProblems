public class Solution {
    public int NumberOfSteps(int num) {
        if (num == 0)
            return 0;
        int counter = 0;
        while (num != 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
                counter++;
            }
            if (num % 2 != 0)
            {
                num--;
                counter++;
            }
        }
        return counter;
    }
}