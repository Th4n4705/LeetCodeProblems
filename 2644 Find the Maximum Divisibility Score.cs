public class Solution {
    public int MaxDivScore(int[] nums, int[] divisors) {
        int counter = 0;
        int index = 0;
        Array.Sort(divisors);
        for (int i = 0; i < divisors.Length; i++)
        {
            int count = 0;
            foreach (var n in nums)
                if (n % divisors[i] == 0)
                    count++;
            if (count > counter)
            {
                counter = count;
                index = i;
            }
        }
        return divisors[index];
    }
}