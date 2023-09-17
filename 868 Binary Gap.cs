public class Solution {
    public int BinaryGap(int n) {
        int previouse = 32;
        int distance = 0;
        int pos = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                distance = Math.Max(distance, pos - previouse);
                previouse = pos;
            }
            n /= 2;
            pos++;
        }
        return distance;
    }
}