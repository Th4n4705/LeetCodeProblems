public class Solution {
    public int CountDigits(int num) {
        int counter = 0;
        int i = num;
        while (i > 0)
        {
            if (num % (i % 10) == 0)
                counter++;
            i = i / 10;
        }
        return counter;
    }
}