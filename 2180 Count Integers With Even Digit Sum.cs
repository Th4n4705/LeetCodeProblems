public class Solution {
    public int CountEven(int num) {
        int ans = 0;
        for (int i = 2; i <= num; i++)
        {
            int sum = 0;
            int val = i;
            while (val > 0)
            {
                sum += val % 10;
                val /= 10;
            }
            if (sum % 2 == 0)
                ans++;
        }
        return ans;
    }
}