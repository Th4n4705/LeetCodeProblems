public class Solution {
    public int CountPrimeSetBits(int left, int right) {
        int ans = 0;
        for (int i = left; i <= right; i++)
        {
            int num = i;
            int counter = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                    counter++;
                num /= 2;
            }
            if (IsPrime (counter))
                ans++;
        }
        return ans;
    }

    bool IsPrime(int n)
    {
        int counter = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                counter++;
        return counter == 2;
    }
}