public class Solution {
    public int[] EvenOddBit(int n) {
        if (n == 1)
            return new [] {1, 0};
        string number = Convert.ToString(n, 2);
        int even = 0;
        int odd = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int index = number.Length - i - 1;
            if (number[index] == '1')
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
            }
        }
        return new [] {even, odd};
    }
}